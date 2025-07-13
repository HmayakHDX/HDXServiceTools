
# HDX Service Tools

**HDX Service Tools** is a Windows desktop application built with .NET 8.0 and Windows Forms, developed to reduce manual engineer time by automating common support workflows related to HDX WILL systems. The tool aims to provide guided installation, built-in troubleshooting, and direct ticket escalation—currently distributed as a standalone executable suitable for field use.

This proof-of-concept demonstrates how internal tooling can reduce technician dependency, support volume, and variability in how support tasks are performed, while remaining flexible enough to grow with future operational needs.

## Status

- **Stage:** Proof of Concept  
- **Deployment:** Single executable (packaging may evolve)  
- **Audience:** External IT teams, clinic staff, internal engineering team  

## Features

### Installer Module
Guides the installation of Will-Master, OnDemand3D, and supporting dependencies using a staged UI. Includes:

- Asynchronous file download and ZIP extraction  
- Task-based install logic via `IInstallHandler` implementations  
- Cancellation support with rollback logic and safe exit handling  

### Troubleshooter Module
Enables guided diagnosis and resolution of known errors using:

- Embedded JSON config mapped to `ErrorInfo` objects  
- Error-specific handlers implementing `IErrorHandler`  
- Delegated status updates with optional fallback to ticket submission  

### Support Ticket Module
Submits Freshdesk tickets directly from the application with:

- Validated input fields, optional TeamViewer info, and automatic session log attachment  
- API requests formatted using `MultipartFormDataContent` to support both form fields and file uploads  
- Authenticated via Base64-encoded API key, with responses handled to confirm ticket creation or surface errors  

### Planned QA Tooling (Conceptual Only)
A placeholder button exists for a future QA/QC module, with a message box describing the intended functionality (e.g., automating phantom scans and image quality validation). No functional code or technical scaffolding currently exists for this feature; implementation would depend on R&D input regarding data access and imaging APIs.

## Architecture Overview

### Modular Design (Early Stage)
Installation and troubleshooting workflows are modularized via the `IInstallHandler` and `IErrorHandler` interfaces, enabling new functionality to be added with minimal changes to the UI layer. While the application remains tightly bound to WinForms, this pattern supports clean separation of concerns and future extensibility.

### UI Flow
`FormManager` centralizes navigation between the main modules: `EntryForm`, `InstallerForm`, `TroubleshooterForm`, and `SubmitTicketForm`.

### Logging
A per-session log file is created in `C:\Will-Master\Log\ServiceTool`, with unified logging for all major operations and exception handling.

### Error Mapping
Troubleshooter errors are defined in `knownErrors.json` and resolved via code-mapped handlers. Errors are filtered dynamically based on user input.

### Deployment Model
Currently distributed as a single self-contained executable for ease of field deployment and testing. The structure allows for future flexibility in packaging, installation, or backend connectivity if scaling or integration requirements evolve.

## Project Structure

```bash
HDX_ServiceTools/
│
├── Core/                   # Entry point and form management
│   └── Program.cs
│   └── FormManager.cs
│
├── Forms/                  # UI components
│   └── EntryForm.cs
│   └── InstallerForm.cs
│   └── TroubleshooterForm.cs
│   └── SubmitTicketForm.cs
│
├── Helpers/                # Shared utilities
│   └── InstallUtils.cs
│   └── InterfaceUtils.cs
│   └── Logger.cs
│   └── ServiceUtils.cs
│   └── NetworkUtils.cs
│   └── FreshdeskClient.cs
│   └── UserPrompts.cs
│
├── InstallHandlers/        # Installer logic
│   └── IInstallHandler.cs
│   └── WMODHandler.cs
│
├── TroubleshootHandlers/   # Error resolution logic
│   └── IErrorHandler.cs
│   └── H0080Handler.cs
│
├── Models/                 # Data models
│   └── ErrorInfo.cs
│   └── InstallationInfo.cs
│
├── Resources/              # Embedded assets
│   └── Logo.png
│   └── knownErrors.json    # JSON-configured error mapping
│   └── installOptions.json # JSON-configured installation mapping
```

## Roadmap

- Expand error and installer handler coverage  
- Convert troubleshooting handlers to async with cancellation  
- Secure API key delegation via AWS Lambda or similar backend  
- Evaluate feasibility of QA/QC tooling with R&D collaboration  
