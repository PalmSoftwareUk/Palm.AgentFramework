# Palm.AgentFramework

[![NuGet](https://img.shields.io/nuget/v/Palm.AgentFramework.Core)](https://www.nuget.org/packages/Palm.AgentFramework.Core)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Palm.AgentFramework is an AI Agent Framework built on .NET 8. It allows you to create AI-driven agents and integrate with various LLM (Large Language Model) providers. The project is modular and is distributed as NuGet packages.

🚀 Features

*   **Modular Architecture:** The core framework, input management, and providers are distributed as separate packages.
*   **Flexible API:** All agents inherit from the `IAgent` interface.
*   **Supports Multiple LLM Providers:** Can integrate with OpenAI, Gemini, and more.
*   **Customizable Input and Output Models:** Compatible with `IInput` and `IOutput` interfaces.

📂 Project Structure

    Palm.AgentFramework/
    ├── src/
    │   ├── Palm.AgentFramework.Core/       # Core framework
    │   ├── Palm.AgentFramework.Inputs/     # Input management
    │   ├── Palm.AgentFramework.Providers/  # LLM providers
    ├── tests/                              # Unit tests
    ├── README.md                           # Project documentation
    ├── Palm.AgentFramework.sln             # Solution file



📦 Installation

To install the framework via NuGet, use the following command:

```bash
dotnet add package Palm.AgentFramework.Core

📜 License

This project is licensed under the MIT License. For more details, see the LICENSE file.

💡 Contributing

To contribute, follow these steps:

Fork the repository
Create a new branch for your changes
Make your updates and commit them
Open a Pull Request (PR)
📞 Contact

For inquiries and suggestions, reach out to us:

📧 Email: info@palm-softwware.com
🔗 GitHub: Palm.AgentFramework  (Replace with your repo link)

