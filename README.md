# Projeto ScreenSound

Este repositório contém o código fonte do projeto **ScreenSound**. É um aplicativo desktop desenvolvido em C# que permite o cadastro e gerenciamento de informações sobre músicos, suas músicas, álbuns e outros detalhes relevantes. O projeto utiliza o Entity Framework Core para interagir com um banco de dados SQL Server, garantindo a persistência dos dados de forma organizada e eficiente.

## Pré-requisitos

- Visual Studio 2022 ou superior
- .NET 7 SDK
- SQL Server Express LocalDB (geralmente instalado junto com o Visual Studio)

## Primeiro Passo: Criar o Banco de Dados

Para utilizarmos o SQL Server no projeto, é necessário ter o componente SQL Server Express LocalDB instalado. Normalmente, este componente é instalado com o Visual Studio durante o processo padrão de instalação. No entanto, siga os passos abaixo para verificar se está tudo instalado corretamente:

1. Abra o **Visual Studio Installer**.
2. Em **Visual Studio Community 2022**, na aba **Instalados**, clique em **Modificar**.
3. Na aba **Componentes Individuais**, pesquise por “sql” na caixa de pesquisa e verifique se o componente **SQL Server Express 2019 LocalDB** está assinalado.

### Criando o Banco de Dados ScreenSound

1. No Visual Studio, vá em **Exibir > Pesquisador de Objetos do SQL Server**. Uma janela será aberta na lateral esquerda do Visual Studio.
2. Nessa janela, localize a pasta **Banco de Dados**. Clique com o botão direito sobre ela e selecione **Adicionar Novo Banco de Dados**.
3. Nomeie o banco de dados como **ScreenSound** e clique em **OK**. O banco de dados aparecerá na lista de bancos à esquerda.

## Segundo Passo: Instalar os Pacotes

Instale os seguintes pacotes:

- `Microsoft.Data.SqlClient` versão 5.1.2
- `Microsoft.EntityFrameworkCore.Design` versão 7.0.14
- `Microsoft.EntityFrameworkCore.Tools` versão 7.0.14
- `Microsoft.EntityFrameworkCore.SqlServer` versão 7.0.14

### Exemplo com Microsoft.Data.SqlClient no Visual Studio

1. Vá em **Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução…**.
2. Na aba **Procurar**, busque por "SQL Client". O primeiro resultado será o `Microsoft.Data.SqlClient`. Marque o projeto **ScreenSound** e clique em **Instalar**. Aceite as licenças para concluir a instalação.

### Configurando a Conexão

Para fazer a conexão com o banco de dados:

1. No Pesquisador de Objetos do SQL Server, clique com o botão direito sobre o banco de dados **ScreenSound** e selecione **Propriedades**.
2. Copie a **Cadeia de Conexão** exibida.

No seu projeto, crie uma variável privada chamada `connectionString` e atribua a ela as informações copiadas. Remova o valor padrão de `Connect Timeout` (30) para otimizar a execução.

## Adicionar Migration

Com os pacotes instalados, adicione a primeira migration ao projeto:

1. Vá em **Ferramentas > Gerenciador de Pacotes do NuGet > Console do Gerenciador de Pacotes**.
2. Execute o seguinte comando para adicionar a migration inicial:

    ```bash
    Add-Migration projetoInicial
    ```

As migrations são um recurso do Entity Framework que permite gerenciar a estrutura e as versões do banco de dados sem a necessidade de editar scripts SQL manualmente.

## Adicionar o Pacote Proxies

1. No Gerenciador de Soluções, clique com o botão direito em **ScreenSound** e selecione **Editar Arquivo do Projeto**.
2. Adicione a seguinte referência no `<ItemGroup>`:

    ```xml
    <PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="7.0.14" />
    ```

Salve o arquivo para adicionar o pacote ao projeto.

### Uso do Pacote Proxies: `UseLazyLoadingProxies()`

Para usar o pacote Proxies:

1. No Gerenciador de Soluções, abra a pasta **Banco** e edite o arquivo `ScreenSoundContext.cs`.
2. No método `OnConfiguring()`, adicione `UseLazyLoadingProxies()` após `UseSqlServer()`:

    ```csharp
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(connectionString)
            .UseLazyLoadingProxies(); 
    }
    ```

Salve o arquivo para habilitar o uso do pacote no projeto.

Abaixo está uma descrição informal narrando os passos que executei.

Primeiro passo é criar o banco de dados
Para utilizarmos o SQL Server no projeto, é preciso que você tenha instalado o seu componente. Geralmente, este componente já é instalado junto com o Visual Studio quando você faz o processo padrão de instalação, mas você pode seguir o passo a passo abaixo para conferir se tudo está instalado corretamente:

Abra o Visual Studio Installer;
Em Visual Studio Community 2022, na aba instalados, clique em Modificar;
Na aba Componentes individuais, pesquise por “sql” na caixa de pesquisa e verifique se o componente SQL Server Express 2019 LocalDB está assinalado.
Criando o banco de dados ScreenSound : Para criarmos um banco para utilizar na nossa aplicação, vamos em "Exibir > Pesquisador de Objetos do SQL Server". Ao clicar nele, abrirá uma janela na lateral esquerda do Visual Studio.

Nessa janela do Pesquisador de Objetos é onde vamos conseguir gerenciar o nosso banco. Teremos a pasta "Banco de Dados", e clicando com o botão direito sobre ela, temos a opção "Adicionar Novo Banco de Dados". Vamos selecionar essa opção e criar um banco de dados com o nome do nosso projeto. Portanto, vamos chamá-lo de ScreenSound.

Após pressionar "Enter" ou clicar em "OK", aparecerá na lista de bancos à esquerda todos os bancos disponíveis, inclusive o ScreenSound que acabamos de criar.
Segundo Passo
instalar os pacotes:
Microsoft.Data.SqlClient 5.1.2, Microsoft Entity Framework Core Design 7.014 , Microsoft Entity Framework Core Tools7.014 e Microsoft Entity Framework Core.SqlServer 7.0.14.

Exemplo com Microsoft.Data.SqlClient no Visual Studio, vamos em "Ferramentas > Gerenciador de Pacotes do NuGet > Gerenciar Pacotes do NuGet para a Solução…". Na aba "Procurar", vamos pesquisar por "SQL Client". O primeiro exibido será o Microsoft.Data.SqlClient, o qual utilizaremos em nosso projeto para estabelecer o vínculo do banco de dados com o projeto em si. À direita, vamos marcar o projeto ScreenSound e clicar em "Instalar". Para concluir, devemos aceitar as licenças.
Para fazer a conexão, precisamos passar o caminho onde está o banco de dados e mais algumas outras informações de configuração. Para localizar essas informações, vamos ao Pesquisador de Objetos do SQL Server, clicamos com o botão direito sobre o banco de dados ScreenSound e vamos em "Propriedades".


Na lateral direita, aparecerão várias informações de propriedade. Precisamos da "Cadeia de conexão". Vamos copiar as informações desse campo para usá-las na classe Connection.

Feito isso, precisamos trazer essas informações. Elas serão a nossa string de conexão. Portanto, podemos criar um private string que se chamará connectionString. Após o igual (=), passaremos todas as informações copiadas das propriedades do banco. Vamos apenas remover o Connect Timeout que vem por padrão 30, para que a execução seja um pouco mais rápida.

Adicionar migration
Com os pacotes instalados, precisamos adicionar a primeira migration ao nosso projeto.

Para fazer isso, vamos em "Ferramentas > Gerenciador de pacotes do NuGet > Console do gerenciador de pacotes". É nesse console que vamos executar os comandos relacionados às migrations. Primeiramente, vamos adicionar essa migration inicial, que é referente ao status inicial do nosso banco. Vamos usar o comando Add.

Quando escrevemos "Add", se pressionarmos "Tab", ele já começa a sugerir algumas opções. Podemos começar a escrever migration, e a sugestão de que queremos usar essa migration irá aparecer.

Vamos usar "Tab" novamente para ele autocompletar e também precisamos informar qual será o nome inicial, o nome da nossa primeira migration. Podemos colocar projeto inicial.

Add-Migration projetoInicial
As migrations são um recurso do Entity que nos permite gerenciar tanto a estrutura do nosso banco quanto as diferentes versões que ele terá durante o projeto, sem precisar mexer nos scripts SQL.
Adicionando o Pacote Proxies
No nosso Gerenciador de Soluções, clicamos em ScreenSound com o botão direito e selecionamos a opção "Editar Arquivo do Projeto". Esse arquivo tem algumas configurações do nosso projeto, e é no <ItemGroup> que vamos adicionar a referência para o nosso pacote.
Após o fechamento da última referência de pacote adicionada, vamos colar a referência que
<PackageReference Include="Microsoft.EntityFrameworkCore.Proxies" Version="7.0.14" />
Essa referência de pacote que adicionamos inclui o Microsoft Entity Framework Core Proxies na versão 7.0.14. Agora salvamos o arquivo, e pronto! O pacote já foi adicionado ao projeto.
Uso do pacote Proxies: UseLazyLoadingProxies()
O próximo passo para utilizar esse pacote no nosso projeto é ir ao Gerenciador de Soluções, na nossa pasta "Banco", para abrir o arquivo ScreenSoundContext.cs.

Nesse arquivo, onde temos um OnConfiguring(), precisamos adicionar um novo Use. No momento, temos o UseSqlServer(), e logo depois dele vamos colocar um ponto e UseLazyLoadingProxies(). Através desse Use, vamos conseguir realmente utilizar o nosso pacote.
ScreenSoundContext.cs
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
        optionsBuilder
                .UseSqlServer(connectionString)
                .UseLazyLoadingProxies(); 
}
Ao salvar o arquivo, já podemos utilizar o pacote em nosso projeto.


