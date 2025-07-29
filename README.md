# 🌀 Onatrix

**Onatrix** is a content-driven web platform built with **ASP.NET Core** and **Umbraco CMS**.  
It leverages the flexibility of Umbraco with the power of .NET to create a dynamic, easily managed website experience.

---

## 🚀 Features

- 💡 CMS-powered content using Umbraco
- ⚙️ Built with ASP.NET Core (.NET 6+)
- 🔧 Structured folder setup with `Models`, `Views`, and `Controllers`
- 🌐 Responsive front-end layout
- 🧩 Extendable through uSync configurations

---

## 📂 Project Structure

```

Onatrix/
├── Models/                    # Custom view models
├── Views/                     # Razor views
├── wwwroot/                   # Static files (CSS, JS, images)
├── umbraco/                   # CMS data
├── uSync/                     # Umbraco sync config (optional)
├── Program.cs                 # Entry point
├── appsettings.json           # Configuration
└── Onatrix.csproj             # Project file

````

---

## 🛠️ Getting Started

1. **Install prerequisites**:
   - [.NET SDK 6.0+](https://dotnet.microsoft.com/en-us/download)
   - [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or LocalDB
   - [Visual Studio 2022+](https://visualstudio.microsoft.com/) (recommended)

2. **Restore and run**:
   ```bash
   dotnet restore
   dotnet run
````

3. Open your browser and go to:
   `http://localhost:5000` or `https://localhost:5001`

---

## 🧠 Notes

* This project uses **Umbraco CMS**, which provides an admin dashboard at `/umbraco`.
* You can configure your connection string in `appsettings.json`.
* If you're deploying, make sure to exclude:

  * `/bin/`, `/obj/`, `.vs/`, `*.user` files from version control.

---

## 📄 License

This project is provided for educational or demo purposes.
Feel free to fork and adapt it for your own needs.

---

> Created by **Nour** — .NET Fullstack Developer & 3D Visual Designer

