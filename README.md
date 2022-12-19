# Создание EntityFramework Context для MsSQL
### Подключение библиотек

Необходимые библиотеки:

- Miсrosoft.EntityFrameworkCore.SqlServer
- Miсrosoft.EntityFrameworkCore.Design
- Miсrosoft.EntityFrameworkCore.Tools
- Miсrosoft.EntityFrameworkCore

### Подключение entity к проекту через консоль 

Переход в директорию проекта

```sh
cd solution_name\project_name\
```

Установка dotnet-ef

```sh
dotnet tool install --global dotnet-ef
```

Создание контекста и моделей данных

```sh
dotnet ef dbcontext scaffold "Server=[Server];Database=[DatabaseName];Trusted_Connection=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -o [OutputDir]
```

### Подключение контекста к api 

Для работы с entity в api необходимо добавить контекст базы данных в файл Program.cs

```sh
builder.Services.AddDbContext<[DbContextClass]>();
```

### Подключение entity к проекту через консоль nuget

```sh
Scaffold-Dbcontext "Server=[Server];Database=[DatabaseName];Trusted_Connection=True;Encrypt=False" Microsoft.EntityFrameworkCore.SqlServer -o [OutputDir]
```

### Использование контекста базы данных в контроллерах

В конструкторах контроллеров необходимо указать раннее созданный класс контекста базы. Например:

```sh
public [ControllerName]([DatabaseContextClass] context)
{
    _context = context;
}
```

Переменная **_context** ялвяется приватным атрибутом класса и используется для обращения к бд
