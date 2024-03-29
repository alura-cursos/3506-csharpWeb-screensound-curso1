Primeiro passo é criar o banco de dados
Criando o banco de dados ScreenSound : Para criarmos um banco para utilizar na nossa aplicação, vamos em "Exibir > Pesquisador de Objetos do SQL Server". Ao clicar nele, abrirá uma janela na lateral esquerda do Visual Studio.

Nessa janela do Pesquisador de Objetos é onde vamos conseguir gerenciar o nosso banco. Teremos a pasta "Banco de Dados", e clicando com o botão direito sobre ela, temos a opção "Adicionar Novo Banco de Dados". Vamos selecionar essa opção e criar um banco de dados com o nome do nosso projeto. Portanto, vamos chamá-lo de ScreenSound.

Após pressionar "Enter" ou clicar em "OK", aparecerá na lista de bancos à esquerda todos os bancos disponíveis, inclusive o ScreenSound que acabamos de criar.
Segundo Passo
instalar os pacotes: Microsoft.Data.SqlClient 5.1.2, Microsoft Entity Framework Core Design 7.013 , Microsoft Entity Framework Core Tools7.013 e Microsoft Entity Framework Core.SqlServer 7.0.13.

Exemplo com Microsoft.Data.SqlClient no Visual Studio, vamos em "Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução…". Na aba "Procurar", vamos pesquisar por "SQL Client". O primeiro exibido será o Microsoft.Data.SqlClient, o qual utilizaremos em nosso projeto para estabelecer o vínculo do banco de dados com o projeto em si. À direita, vamos marcar o projeto ScreenSound e clicar em "Instalar". Para concluir, devemos aceitar as licenças.
Para fazer a conexão, precisamos passar o caminho onde está o banco de dados e mais algumas outras informações de configuração. Para localizar essas informações, vamos ao Pesquisador de Objetos do SQL Server, clicamos com o botão direito sobre o banco de dados ScreenSound e vamos em "Propriedades".


Na lateral direita, aparecerão várias informações de propriedade. Precisamos da "Cadeia de conexão". Vamos copiar as informações desse campo para usá-las na classe Connection.

Feito isso, precisamos trazer essas informações. Elas serão a nossa string de conexão. Portanto, podemos criar um private string que se chamará connectionString. Após o igual (=), passaremos todas as informações copiadas das propriedades do banco. Vamos apenas remover o Connect Timeout que vem por padrão 30, para que a execução seja um pouco mais rápida.
