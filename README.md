# Projeto CoffeeShop

![image](https://user-images.githubusercontent.com/99232015/215018655-7cadd1cf-e8bf-4759-b2a1-d75262e4a022.png)


## Requisitos: 
+ Para o funcionamento do programa, será necessário ter instalado o "SQL Server Management Studio" e ter um servidor local na maquina, ou, alterar o connectionString.

  No programa, a connectionString está da seguinte forma:
![image](https://user-images.githubusercontent.com/99232015/215017772-2aadb27e-0b1e-40d5-865f-fd64fa239dec.png)

  após conferir a connectionString com o servidor instalado na máquina, escrever no console do gerenciador de pacotes do Visual Studio o comando: 
```
update-database CoffeeShop
```
   O comando irá criar o banco de dados de acordo com a Migrations criada na pasta, e assim, o programa já estará pronto para ser executado.

## Sobre:
  O Projeto foi feito com C#, no padrão MVC, na View Foi utilizado HTML, CSS e um pouco de Bootstrap.

  Pacotes NuGet que foram utilizados:
  + Entity Framework Core
  + Entity Framework Core Design
  + Entity Framework Core SqlServer
  + Entity Framework Core Tools
  
  

