# HexagonalArchitecture-product-api

Este repositório contém uma **Web API de Produtos** desenvolvida com o objetivo de praticar conceitos de arquitetura limpa, especialmente a **Arquitetura Hexagonal (Ports and Adapters)**, utilizando tecnologias modernas e boas práticas do ecossistema .NET.

## 📌 Objetivo

Projeto criado para fins de estudo e prática de desenvolvimento backend com .NET, aplicando:

- **Arquitetura Hexagonal (Ports and Adapters)**
- **Separação de responsabilidades com DTOs**
- **Persistência com SQLite**
- **Desenvolvimento de APIs REST com ASP.NET Core**

---

## 🚀 Tecnologias e Conceitos Utilizados

- **.NET 9 / ASP.NET Core**
- **Entity Framework Core**
- **SQLite como banco de dados**
- **Arquitetura Hexagonal (Ports & Adapters)**
- **DTOs para abstração entre camadas**
- **Injeção de dependência**
- **Swagger para documentação da API**
- **xUnit + Testcontainers (para testes de integração - opcional)**

---

## 🧱 Estrutura do Projeto

O projeto segue a ideia de separação por camadas, com responsabilidades bem definidas:

- **ProductApi --> Camada de apresentação (Controllers, Middlewares, Program.cs)**
- **Product.Application --> Casos de uso, interfaces (Ports), serviços**
- **Product.Domain --> Entidades de domínio e regras de negócio**
- **Product.Persistence --> Adapters (repositórios, contexto EF)**

