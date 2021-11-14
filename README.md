# Blue Bank - CtrlZ

Projeto desenvolvido para conclusão do Curso Gama Academy .NET - Digital Academy XP.

## O Desafio

O fictício Blue bank está construindo uma nova plataforma e precisa 
de uma **API com arquitetura REST** para gerenciar as transações. 
O sistema deve permitir **cadastro e gerenciamento de novos clientes**, incluindo dados pessoais e dados para contato. O cliente deve ser atrelado a uma conta bancária e registrar o histórico de **transações entre contas**.


## Para rodar local

Clonar o repositório
```bash
  git clone https://github.com/filipifirmino/BlueBank-ctrz
```

* Vá a pasta do projeto
* Abrir com Visual Studio
* Iniciar a aplicação console

## API 


### Rotas de Client
Cadastrar cliente:
``[POST] /Client``

Listar todos os clientes:
``[GET] /Client``

Listar cliente por id:
``[GET] /Client/{Id}``

Atualizar cliente:
``[PUT] /Client``

Delete Cliente:
``[DELET] /Client/{id}``


### Rotas de Account
Listar todas as contas:
``[GET] /All``

Listar conta por id:
``[GET] /Account/{Id}``

Listar hitorico de movimentações da conta por id:
``[GET] /Client/history/{Id}``

##### Transação de conta
Deposito:
``[GET] /api/Transactions/deposit/{AccountId}/{Value}``

Saque:
``[GET] /api/Transactions/withdraw/{AccountId}/{Value}``

Transferencia:
``[GET] /api/Transactions/transfer/{AccountId}/{Value}/{AccountDestinyId}``


## Desenvolvedores

- [@filipifirmino](https://github.com/filipifirmino)
- [@ingrideme](https://www.github.com/ingrideme)
- [@jemouraa](https://www.github.com/jemouraa)
- [@larissapalombo](https://www.github.com/larissapalombo)
- [@rodrigoderkian](https://www.github.com/rodrigoderkian)

## Tecnologias utilizadas

* C# .Net
* SQL Server
* Swagger
* Docker

## Modelagem do Projeto

DDD - Domain Driven Design
CQRS - Command and Query Responsibility Segregation
Repository patners 

## Screenshots

//colocar prints
