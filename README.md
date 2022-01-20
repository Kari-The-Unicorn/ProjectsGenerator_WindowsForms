# ProjectsGenerator_WindowsForms
using SqlExpress
** **
*Note:*

*Adding connection to existing database using Entity Framework:*

*1. Install NuGet packages to your project:*

*-Microsoft.EntityFrameworkCore.Design*

*-Microsoft.EntityFrameworkCore.SqlServer*

*-Microsoft.EntityFrameworkCore.Tools*

*2. In Visual Studio open Package Manager Console and run Scaffold-DbContext command as below:*

*Scaffold-DbContext "[CONNECTION_STRING]" Microsoft.EntityFrameworkCore.SqlServer -Tables [TABLE_NAME]
-Context [DB_CONTEXT_NAME] -OutputDir [OUTPUT_FOLDER_NAME] -DataAnnotations*

  *e.g. Scaffold-DbContext "Data Source=.\SQLEXPRESS;Initial Catalog=TasksCatalog;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer*
  -Tables Task -Context TaskDbContext -OutputDir Models -DataAnnotations*

  *where "Data Source=.\SQLEXPRESS;Initial Catalog=TasksCatalog;Integrated Security=True" - connection string taken from Server Explorer in VS*
  *(right click on db, choose Properties, Connection string will appear in right bottom corner of VS window)*

*3. New directory with OutputDir files e.g. Models is added to project (check Solution Explorer in VS)*

*4. Now you can use database in project by creating db context instance and using tables from database there, e.g.:*

```
List<Task> LoadData()
        {
            using TaskDbContext dbContext = new ();
            return dbContext.Tasks.ToList();
        }
 ```
        
*and load data from table in data grid view control:*

```
void btnReload_Click(object sender, EventArgs e)

        {
        
            dgvTasks.DataSource = LoadData();
            
        }
```
