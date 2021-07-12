# AspNetCore-MVC-EntityFrameworkCore
Projeto utilizando Entity Framework Core em um aplicativo Web ASP.NET Core seguindo o padrão de arquitetura MVC (Model-View-Controller).
<br><em> Tutorial por Tom Dykstra e Rick Anderson - Microsoft </em></br>

## Objetivo do projeto
O aplicativo de exemplo é um site de uma universidade fictícia. O projeto inclui funcionalidades como admissão de alunos, criação de cursos e atribuições de instrutor. 

### Pré-requisitos
<ul>
   <li><a href= "https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019"> Visual Studio 2019 16.8 ou posterior</a> com a carga de trabalho ASP.NET desenvolvimento para a Web; </li>
    <li><a href= "https://dotnet.microsoft.com/download/dotnet/5.0"> SDK do .NET 5,0 ou posterior</a></li>
    <li><a href= "https://docs.microsoft.com/pt-br/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15"> SQL Server LocalDB</a></li>
</ul>

### Pacotes utilizados na aplicação
<ul>
   <li>Microsoft.EntityFrameworkCore.Sqlite - Versão 5.0.6</li>
   <li>Microsoft.EntityFrameworkCore.SqlServer - Versão 5.0.6</li>
   <li>Microsoft.EntityFrameworkCore.Tools - Versão 5.0.6</li>
   <li>Microsoft.EntityFrameworkCore.Design - Versão 5.0.6</li>
</ul>

### Cardinalidade entre as Entidades
<ul>
   <li>Uma relação 1:n entre Student as Enrollment: um aluno pode ser registrado em qualquer número de cursos.</li>
   <li>Uma relação 1:n entre Course as Enrollment: um curso pode ter qualquer quantidade de alunos registrados.</li>
</ul>
