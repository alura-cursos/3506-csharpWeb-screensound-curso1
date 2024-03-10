Primeiro passo é criar o banco de dados
Criando o banco de dados ScreenSound : Para criarmos um banco para utilizar na nossa aplicação, vamos em "Exibir > Pesquisador de Objetos do SQL Server". Ao clicar nele, abrirá uma janela na lateral esquerda do Visual Studio.

Nessa janela do Pesquisador de Objetos é onde vamos conseguir gerenciar o nosso banco. Teremos a pasta "Banco de Dados", e clicando com o botão direito sobre ela, temos a opção "Adicionar Novo Banco de Dados". Vamos selecionar essa opção e criar um banco de dados com o nome do nosso projeto. Portanto, vamos chamá-lo de ScreenSound.

Após pressionar "Enter" ou clicar em "OK", aparecerá na lista de bancos à esquerda todos os bancos disponíveis, inclusive o ScreenSound que acabamos de criar.
Segundo Passo
instalar o pacote: Microsoft.Data.SqlClient
No Visual Studio, vamos em "Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução…". Na aba "Procurar", vamos pesquisar por "SQL Client".

O primeiro exibido será o Microsoft.Data.SqlClient, o qual utilizaremos em nosso projeto para estabelecer o vínculo do banco de dados com o projeto em si. À direita, vamos marcar o projeto ScreenSound e clicar em "Instalar". Para concluir, devemos aceitar as licenças.
