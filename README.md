# SpecPro

SpecPro is a Windows Forms desktop application for managing specialist work records related to mortgage/property sale and auction cases. It stores case information in SQL Server, lets authorized users maintain reference data, and supports operational reporting through Excel import and export.

## What the app does

- Authenticates users and supports administrator/operator roles.
- Manages the main case register, including task/order number, specialist, status, customer, representative, mortgage and credit details, property information, owners, debtors, buyers, sale amounts, fees, VAT flags, auction dates, lots, and closing dates.
- Maintains reference lists for specialists, statuses, customers, representatives, buyers, auction types, operation codes, and prepaid values.
- Tracks user actions in a log table for created, updated, deleted, and transaction-related records.
- Imports receipt/turnover data from Excel and stores it in the database.
- Exports case and daily turnover views to Excel.
- Stores and edits USD/EUR exchange-rate data, including integration points for the National Bank of Georgia currency API.
- Uses typed DataSets for database-backed tables such as `info`, `users`, `customers`, `specialists`, `status`, `represent`, `receipts`, `logs`, `acc`, `buyers`, `prep_tbl`, and `iso`.

## Technology

- C# Windows Forms
- .NET Framework 4.8
- SQL Server / SQL Server LocalDB
- Visual Studio solution/project files: `SpecPro.sln`, `SpecPro.csproj`
- Microsoft Office Interop for Excel export/import

## Database

The application reads its main SQL Server connection from `App.config`:

```xml
<add name="FindId" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=spro;Integrated Security=True;" providerName="System.Data.SqlClient"/>
```

The repository also contains database backup files under `db/12-11-2025/`, including backups for `spro` and `turn`.

## Running

1. Open `SpecPro.sln` in Visual Studio.
2. Restore or create the required SQL Server databases, including `spro` and any dependent `turnover` data used by the app.
3. Confirm the `FindId` connection string in `App.config` points to the correct SQL Server instance.
4. Build and run the project.

The application starts with `Form_Dial`, a login form, and then opens the main `Form_Spec` workspace after successful authentication.
