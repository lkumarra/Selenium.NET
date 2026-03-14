[![Codacy Badge](https://app.codacy.com/project/badge/Grade/81cd46f537d844a58961c2718640b089)](https://www.codacy.com/manual/lkumarra/Selenium.NET?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=lkumarra/Selenium.NET&amp;utm_campaign=Badge_Grade)

# 🧪 Selenium.NET — Page Object Model Framework

A robust, scalable Selenium test automation framework built with **C# / .NET 9** implementing the **Page Object Design Pattern (POM)**. This framework automates the [Guru99 Bank Demo Application](http://www.demo.guru99.com/V4/index.php) and serves as a production-ready template for web UI test automation.

---

## 📐 Architecture Diagram

```
┌─────────────────────────────────────────────────────────────────────────┐
│                          SeleniumPOM Solution                          │
├─────────────────────────────────────────────────────────────────────────┤
│                                                                         │
│  ┌─────────────┐    ┌──────────────┐    ┌────────────────────────────┐  │
│  │  TestCase/   │───▶│ TestContext/  │───▶│       Pages/               │  │
│  │             │    │              │    │                            │  │
│  │ LoginTest   │    │ TestClass    │    │  ┌────────┐  ┌─────────┐  │  │
│  │ HomeTest    │    │ Context      │    │  │Actions/│  │Locators/│  │  │
│  │ NewCustomer │    │              │    │  │        │  │         │  │  │
│  │ EditCustomer│    │ • ExtentRpt  │    │  │LoginPg │  │LoginLoc │  │  │
│  │ DeleteCust  │    │ • SetUp/     │    │  │HomePg  │  │HomeLoc  │  │  │
│  │ NewAccount  │    │   TearDown   │    │  │NewCust │  │NewCustL │  │  │
│  │ EditAccount │    │              │    │  │EditCust│  │EditCustL│  │  │
│  │ DeleteAcct  │    └──────────────┘    │  │DeleteCu│  │DelCustL │  │  │
│  │ Deposit     │                        │  │NewAcct │  │NewAcctL │  │  │
│  │ Withdrawal  │                        │  │EditAcct│  │EditAcctL│  │  │
│  │ FundTransfer│                        │  │DelAcct │  │DelAcctL │  │  │
│  │ BalanceEnq  │                        │  │Deposit │  │DepositL │  │  │
│  │ MiniStmt    │                        │  │Withdraw│  │WithdrawL│  │  │
│  │ CustomStmt  │                        │  │FundTrfr│  │FundTrfrL│  │  │
│  └─────────────┘                        │  │BalEnq  │  │BalEnqL  │  │  │
│                                         │  │MiniStmt│  │MiniStmtL│  │  │
│                                         │  │CustStmt│  │CustStmtL│  │  │
│                                         │  └────────┘  └─────────┘  │  │
│                                         │                            │  │
│                                         │  ┌────────────────────┐    │  │
│                                         │  │    BasePage/       │    │  │
│                                         │  │    Page.cs         │    │  │
│                                         │  │  • WebDriver Init  │    │  │
│                                         │  │  • Browser Setup   │    │  │
│                                         │  │  • Session Mgmt    │    │  │
│                                         │  └────────────────────┘    │  │
│                                         └────────────────────────────┘  │
│                                                                         │
│  ┌──────────────┐  ┌──────────────┐  ┌──────────────┐  ┌────────────┐  │
│  │ Interfaces/  │  │  Utilities/  │  │   Config/    │  │  Setting/  │  │
│  │              │  │              │  │              │  │            │  │
│  │ ILoginPage   │  │ Utils.cs     │  │ AppConfig    │  │ AppConfig  │  │
│  │ IHomePage    │  │ ExtentRpt    │  │ Reader.cs    │  │ Keys.cs    │  │
│  │ INewCustPg   │  │ Helper.cs    │  │ Constants.cs │  │ ObjectRepo │  │
│  │ IEditCustPg  │  │ Log4Net      │  │ appsettings  │  │ sitory.cs  │  │
│  │ IDeleteCust  │  │ Helper.cs    │  │ .json        │  │            │  │
│  │ INewAcctPg   │  │ MailUtil.cs  │  │ extent-      │  └────────────┘  │
│  │ IEditAcctPg  │  │              │  │ config.xml   │                   │
│  │ IDeleteAcct  │  └──────────────┘  └──────────────┘                   │
│  │ IDepositPg   │                                                       │
│  │ IWithdrawal  │  ┌──────────────┐  ┌──────────────┐  ┌────────────┐  │
│  │ IFundTransfr │  │ CustomExcep/ │  │  TestData/   │  │TestReports/│  │
│  │ IBalanceEnq  │  │              │  │              │  │            │  │
│  │ IMiniStmt    │  │ NoSuitable   │  │ Guru99Bank   │  │ extent     │  │
│  │ ICustStmt    │  │ DriverFound  │  │ .xlsx        │  │ .html      │  │
│  │ IConfig      │  │ .cs          │  │              │  │            │  │
│  │ IUtil        │  └──────────────┘  └──────────────┘  └────────────┘  │
│  └──────────────┘                                                       │
│                                                                         │
└─────────────────────────────────────────────────────────────────────────┘
```

---

## 🔄 Test Execution Flow

```
┌──────────┐     ┌──────────────┐     ┌──────────────┐     ┌──────────┐
│  MSTest   │────▶│ TestClass    │────▶│  Page.cs     │────▶│ WebDriver│
│  Runner   │     │ Context      │     │ (BasePage)   │     │ Manager  │
└──────────┘     └──────┬───────┘     └──────┬───────┘     └────┬─────┘
                        │                     │                   │
                        ▼                     ▼                   ▼
                 ┌──────────────┐     ┌──────────────┐     ┌──────────┐
                 │  Test Case   │     │ Action Page  │     │ Chrome / │
                 │  (e.g.       │────▶│ (e.g.        │────▶│ Firefox  │
                 │  LoginTest)  │     │  LoginPage)  │     │ Browser  │
                 └──────────────┘     └──────┬───────┘     └──────────┘
                                             │
                                             ▼
                                      ┌──────────────┐
                                      │  Locator     │
                                      │  (e.g.       │
                                      │  LoginPage   │
                                      │  Locators)   │
                                      └──────┬───────┘
                                             │
                                             ▼
                                      ┌──────────────┐
                                      │  Utils.cs    │
                                      │  • Click     │
                                      │  • SendKeys  │
                                      │  • Wait      │
                                      │  • JS Exec   │
                                      └──────────────┘
```

---

## 🔧 Technology Stack

| Component | Library | Version |
|---|---|---|
| **Runtime** | .NET | 9.0 |
| **Browser Automation** | Selenium WebDriver | 4.29.0 |
| **Browser Support** | Selenium Support | 4.29.0 |
| **Page Objects** | DotNetSeleniumExtras.PageObjects.Core | 4.14.1 |
| **Wait Helpers** | DotNetSeleniumExtras.WaitHelpers | 3.11.0 |
| **Driver Management** | WebDriverManager | 2.17.5 |
| **Test Framework** | MSTest (TestAdapter + Framework) | 3.7.3 |
| **Test SDK** | Microsoft.NET.Test.Sdk | 17.12.0 |
| **Reporting** | ExtentReports | 5.0.4 |
| **Logging** | log4net | 3.0.4 |
| **Configuration** | Microsoft.Extensions.Configuration | 9.0.4 |
| **JSON Handling** | Newtonsoft.Json | 13.0.3 |
| **Database** | MongoDB.Driver | 3.3.0 |

---

## 📁 Project Structure

```
SeleniumPOM/
├── appsettings.json                    # Application configuration (browser, URL, credentials)
├── SeleniumPOM.csproj                  # SDK-style project file targeting .NET 9
│
├── Config/                             # Configuration layer
│   ├── AppConfigReader.cs              # Reads settings from appsettings.json
│   ├── Constants.cs                    # Application-wide constants (email, report paths)
│   └── extent-config.xml              # ExtentReports XML configuration
│
├── CustomException/                    # Custom exception classes
│   └── NoSuitableDriverFound.cs       # Thrown when browser config is invalid
│
├── Interfaces/                         # Interface contracts for all pages
│   ├── IConfig.cs                     # Configuration reader interface
│   ├── IUtil.cs                       # Utility operations interface
│   ├── ILoginPage.cs                  # Login page operations
│   ├── IHomePage.cs                   # Home page navigation
│   ├── INewCostumerPage.cs            # New customer form operations
│   ├── IEditCostumerPage.cs           # Edit customer operations
│   ├── IDeleteCustomerPage.cs         # Delete customer operations
│   ├── INewAccountPage.cs             # New account operations
│   ├── IEditAccountPage.cs            # Edit account operations
│   ├── IDeleteAccountPage.cs          # Delete account operations
│   ├── IDepositPage.cs                # Deposit operations
│   ├── IWithdrawalPage.cs             # Withdrawal operations
│   ├── IFundTransferPage.cs           # Fund transfer operations
│   ├── IBalanceEnquiryPage.cs         # Balance enquiry operations
│   ├── IMiniStatementPage.cs          # Mini statement operations
│   └── ICustomisedStatementPage.cs    # Customised statement operations
│
├── Pages/                              # Page Object Model implementation
│   ├── BasePage/
│   │   └── Page.cs                    # Base class: WebDriver init, browser setup, teardown
│   ├── Locators/                      # Element locators using @FindsBy annotations
│   │   ├── LoginPageLocators.cs
│   │   ├── HomePageLocator.cs
│   │   ├── NewCustomerLocators.cs
│   │   ├── EditCostumerLocator.cs
│   │   ├── DeleteCustomerLocator.cs
│   │   ├── NewAccountLocator.cs
│   │   ├── EditAccountLocator.cs
│   │   ├── DeleteAccountLocator.cs
│   │   ├── DepositLocator.cs
│   │   ├── WithdrawalLocator.cs
│   │   ├── FundTrasferLocator.cs
│   │   ├── BalanceEnquiryLocator.cs
│   │   ├── MiniStatementLocator.cs
│   │   └── CustomisedStatementLocator.cs
│   └── Actions/                       # Page action methods (business logic)
│       ├── LoginPage.cs
│       ├── HomePage.cs
│       ├── NewCustomerPage.cs
│       ├── EditCustomerPage.cs
│       ├── DeleteCustomerPage.cs
│       ├── NewAccountPage.cs
│       ├── EditAccountPage.cs
│       ├── DeleteAccountPage.cs
│       ├── DepositPage.cs
│       ├── WithdrawalPage.cs
│       ├── FundTrasferPage.cs
│       ├── BalanceEnquiryPage.cs
│       ├── MiniStatementPage.cs
│       └── CustomisedStatementPage.cs
│
├── Setting/                            # Application settings
│   ├── AppConfigKeys.cs               # Configuration key constants
│   └── ObjectRepsitory.cs             # Static config object holder
│
├── TestCase/                           # MSTest test classes
│   ├── LoginTest.cs
│   ├── HomeTest.cs
│   ├── NewCustomerTest.cs
│   ├── EditCustomerTest.cs
│   ├── DeleteCustomerTest.cs
│   ├── NewAccountTest.cs
│   ├── EditAccountTest.cs
│   ├── DeleteAccountTest.cs
│   ├── DepositTest.cs
│   ├── WithdrawalTest.cs
│   ├── FundTransferTest.cs
│   ├── BalanceEnquiryTest.cs
│   ├── MiniStatementTest.cs
│   ├── CustomisedStatementTest.cs
│   └── UnitTest1.cs
│
├── TestContextClass/                   # Test lifecycle management
│   └── TestClassContext.cs            # Assembly init/cleanup, ExtentReports setup
│
├── Utilities/                          # Helper utilities
│   ├── Utils.cs                       # WebElement interactions (click, type, wait, JS)
│   ├── ExtentReportsHelper.cs         # ExtentReports 5.x Spark reporter wrapper
│   ├── Log4NetHelper.cs               # log4net programmatic configuration
│   └── MailUtil.cs                    # Email report sender via SMTP
│
├── TestData/                           # Test data files
│   └── Guru99Bank.xlsx                # Excel test data
│
├── TestReports/                        # Generated HTML test reports
│   └── extent.html
│
└── Logs/                               # Generated log files
    ├── FileLogger.log
    └── RollingFileLogger.log
```

---

## 🏗️ Design Patterns & Principles

### Page Object Model (POM)
Each web page is represented by two classes:
- **Locator class** — Defines element locators using `[FindsBy]` attributes with `PageFactory`
- **Action class** — Implements business logic methods that interact with elements

### Interface Segregation
Every page has a corresponding interface (e.g., `ILoginPage`), enabling:
- Loose coupling between test cases and page implementations
- Easy mocking for unit testing
- Clear API contracts

### Base Page Pattern
`Page.cs` serves as the base class providing:
- WebDriver initialization with `WebDriverManager` (auto-downloads correct driver)
- Browser configuration (Chrome/Firefox)
- Session management (cookies, timeouts, window maximization)

### Utility Abstraction
`Utils.cs` wraps common Selenium operations with built-in explicit waits:
- `ClickOnElement()` — Wait + Click
- `EnterTextIntoElement()` — Wait + SendKeys
- `GetElementText()` — Wait + Get Text
- `SelectByVisibleText()` — Dropdown selection
- `JSExecutor()` / `JSExecutorClick()` — JavaScript execution
- `GetAlertTextAndAccept()` — Alert handling

---

## 🔀 Layer Interaction Diagram

```
  Test Layer          Page Layer              Utility Layer         Driver Layer
  ──────────          ──────────              ─────────────         ────────────
       │                   │                       │                     │
       │  Login(user,pwd)  │                       │                     │
       │──────────────────▶│                       │                     │
       │                   │  EnterText(element)   │                     │
       │                   │──────────────────────▶│                     │
       │                   │                       │  FindElement()      │
       │                   │                       │────────────────────▶│
       │                   │                       │  SendKeys()         │
       │                   │                       │────────────────────▶│
       │                   │                       │◀────────────────────│
       │                   │◀──────────────────────│                     │
       │                   │  Click(loginBtn)      │                     │
       │                   │──────────────────────▶│                     │
       │                   │                       │  Click()            │
       │                   │                       │────────────────────▶│
       │                   │                       │◀────────────────────│
       │                   │◀──────────────────────│                     │
       │  return HomePage  │                       │                     │
       │◀──────────────────│                       │                     │
       │                   │                       │                     │
```

---

## 🚀 Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed
- Chrome or Firefox browser installed

### Quick Start

```bash
# Clone the repository
git clone https://github.com/lkumarra/Selenium.NET.git
cd Selenium.NET

# Restore NuGet packages
dotnet restore

# Build the project
dotnet build

# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"

# Run a specific test
dotnet test --filter "VerifyLogin"
```

### Using Visual Studio / VS Code
1. Open `SeleniumPOM.sln`
2. Build the solution (`Ctrl+Shift+B`)
3. Open Test Explorer (`Ctrl+E, T`)
4. Run individual tests or all tests

---

## ⚙️ Configuration

Application settings are in `SeleniumPOM/appsettings.json`:

```json
{
  "AppSettings": {
    "Browser": "Chrome",
    "UserName": "your_username",
    "Password": "your_password",
    "Url": "http://www.demo.guru99.com/V4/index.php"
  }
}
```

| Key | Description | Values |
|---|---|---|
| `Browser` | Browser to use for testing | `Chrome`, `Firefox` |
| `UserName` | Login username | Any valid username |
| `Password` | Login password | Corresponding password |
| `Url` | Application URL | Target web application URL |

---

## 📊 Reporting

### ExtentReports (HTML)
- Reports are auto-generated at `TestReports/extent.html`
- Uses **ExtentSparkReporter** (ExtentReports 5.x)
- Includes system info, test status (Pass/Fail/Skip), and screenshots

### log4net Logging
- **Console Appender** — Real-time output during test execution
- **File Appender** — `Logs/FileLogger.log`
- **Rolling File Appender** — `Logs/RollingFileLogger.log` (max 15 backups)

### Email Reports
To enable email reports after test execution:
1. Fill in email details in `Config/Constants.cs`
2. Uncomment `MailUtil.SendAttachedReport()` in `TestContextClass/TestClassContext.cs`

---

## 📦 Migration Summary (v1 → v2)

| Aspect | Before (v1) | After (v2) |
|---|---|---|
| **Framework** | .NET Framework 4.7.2 | .NET 9.0 |
| **Project Format** | Legacy `.csproj` + `packages.config` | SDK-style `.csproj` |
| **Selenium** | 3.141.0 | 4.29.0 |
| **PageFactory** | `OpenQA.Selenium.Support.PageObjects` | `DotNetSeleniumExtras.PageObjects.Core` |
| **ExpectedConditions** | `OpenQA.Selenium.Support.UI` | `SeleniumExtras.WaitHelpers` |
| **Configuration** | `App.config` + `ConfigurationManager` | `appsettings.json` + `IConfiguration` |
| **Reporting** | ExtentReports 3.x (`ExtentHtmlReporter`) | ExtentReports 5.x (`ExtentSparkReporter`) |
| **Test Framework** | MSTest 2.1.1 | MSTest 3.7.3 |
| **Driver Management** | Manual driver binaries | WebDriverManager 2.17.5 (auto-download) |

---

## 📄 License

This project is open source. See the [license](SeleniumPOM/license) file for details.
