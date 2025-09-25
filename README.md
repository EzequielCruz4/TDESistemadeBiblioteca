## Documentação: Projeto Sistema de Biblioteca em C#
Autor: Ezequiel Cruz
Data: 25 de setembro de 2025
Versão: 1.0.0

# 1. Visão Geral do Projeto
O projeto "Sistema de Biblioteca" é uma aplicação de console desenvolvida em C# como um exercício prático para a aplicação dos conceitos fundamentais da Programação Orientada a Objetos (POO). O software simula o funcionamento básico de uma biblioteca, permitindo o cadastro de livros e a listagem do acervo existente.

O foco principal não está na complexidade das funcionalidades, mas na correta estruturação do código, utilizando classes, objetos, encapsulamento e outros pilares da POO para criar um sistema coeso, organizado e de fácil manutenção.

# 2. Objetivo
O objetivo central deste projeto é demonstrar a compreensão e a aplicação prática dos seguintes conceitos de Programação Orientada a Objetos:

Classes e Objetos: Modelar entidades do mundo real (Livro, Biblioteca) em estruturas de código.

Encapsulamento: Proteger a integridade dos dados, ocultando o estado interno dos objetos.

Abstração: Focar nos atributos e comportamentos essenciais das entidades, simplificando sua representação.

Construtores: Garantir que os objetos sejam criados em um estado consistente e válido.

# 3. Tecnologias Utilizadas
Linguagem de Programação: C#

Plataforma: .NET

Tipo de Aplicação: Console Application

Ambiente de Desenvolvimento (IDE): Visual Studio (ou similar, como VS Code)

# 4. Arquitetura e Modelagem
O sistema foi arquitetado em torno de duas classes principais que representam as entidades do domínio do problema.

# 4.1. Classe Livro
Esta classe serve como um modelo para representar um livro.

Responsabilidade: Armazenar os dados referentes a um único livro.

Atributos (privados):

_titulo: (string) Armazena o título do livro.

_autor: (string) Armazena o nome do autor.

_anoPublicacao: (int) Armazena o ano de publicação.

Métodos:

Livro(string titulo, string autor, int ano): Construtor que inicializa o objeto com os dados essenciais.

GetTitulo(): Método público que retorna o título do livro, respeitando o encapsulamento.

ExibirInfo(): Método que imprime no console os detalhes do livro de forma formatada.

# 4.2. Classe Biblioteca
Esta classe gerencia a coleção de livros e as operações sobre o acervo.

Responsabilidade: Orquestrar o acervo de livros.

Atributos (privados):

_acervoDeLivros: (List<Livro>) Uma lista que armazena todos os objetos do tipo Livro.

Atributos (públicos):

NomeDaBiblioteca: (string) Armazena o nome da biblioteca.

Métodos:

Biblioteca(string nome): Construtor que define o nome da biblioteca e inicializa a lista do acervo.

CadastrarLivro(Livro livroParaAdicionar): Adiciona um objeto Livro à lista do acervo.

ListarLivros(): Itera sobre a lista de livros e invoca o método ExibirInfo() de cada um para mostrar o acervo completo.

# 5. Funcionalidades Implementadas
A interface do usuário é operada via console e oferece as seguintes funcionalidades:

Funcionalidade	Descrição
1. Cadastrar Livro	O usuário é guiado por um formulário no console para inserir o título, autor e ano de publicação de um novo livro. O sistema cria um objeto Livro e o armazena no acervo.
2. Listar Acervo	Após o encerramento do processo de cadastro, o sistema exibe todos os livros registrados, com suas respectivas informações formatadas.

# 6. Como Executar o Projeto
Pré-requisitos:

Ter o SDK do .NET instalado.

Um editor de código ou IDE, como o Visual Studio.

Passos para Compilação e Execução:

Clone ou faça o download dos arquivos do projeto.

Abra o terminal na pasta raiz do projeto.

Execute o comando dotnet run.

A aplicação será iniciada no console, e você poderá interagir com o menu para cadastrar os livros.

# 7. Conclusão e Pontos de Melhoria
O projeto atingiu com sucesso seus objetivos educacionais, implementando um sistema funcional que demonstra de maneira clara a aplicação dos pilares da Programação Orientada a Objetos. O código resultante é legível, modular e segue boas práticas de encapsulamento e abstração.

# Possíveis Melhorias Futuras:

Implementação de funcionalidades de busca de livros (por ID, título ou autor).

Criação da classe Leitor para gerenciar usuários da biblioteca.

Desenvolvimento de um sistema de empréstimo e devolução.

Persistência de dados em arquivos (como .txt ou .json) para que as informações não sejam perdidas ao fechar a aplicação.

Refatoração do menu principal na classe Program para torná-lo mais robusto e com mais opções.
