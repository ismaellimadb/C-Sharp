# C-Sharp
No visual Studio ir em Exibir e clicar em Gerenciador de Servidores e nessa seção,fazer a conexão com o banco de dados desejado caso ja não houver e dali ir em propriedades da conexão para pegar a string de conexão.

No código, declarar uma variavel do tipo String e colocar a String de conexão Adquirida na variavel.

Ter os using System.Data; e using System.Data.SqlClient; no código para poder se declarar uma variavel do tipo SqlConnection e assim como no exemplo: using (SqlConnection con = new SqlConnection(connectionString));, usar a string de conexão Adquirida nessa variavel SqlConnection.
