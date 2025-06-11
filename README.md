# 🥘 UaiFood

UaiFood é uma aplicação desenvolvida em **C#** com banco de dados **MySQL**, inspirada nos aplicativos de delivery. O sistema simula uma plataforma de pedidos de comida, com funcionalidades para clientes e restaurantes, além de integração com o **bot do Telegram** para notificações.

## 📦 Funcionalidades

### 👤 Cliente
- Cadastro e login
- Visualização e busca de restaurantes
- Visualização e busca de produtos
- Criação de carrinho
- Cadastro de pedidos com múltiplos produtos
- Acompanhamento do status do pedido:
  - **Pedido Realizado**
  - **Saiu para Entrega**
  - **Pedido Entregue**

### 🍽️ Restaurante
- Cadastro e login
- Cadastro de produtos
- Visualização dos pedidos
- Alteração do status dos pedidos:
  - **Saiu para Entrega**
  - **Pedido Entregue**

### 🤖 Integração com Telegram
- Envio de notificações via **Bot do Telegram**
- Necessário inserir a chave da API do Telegram no código

---

## 🛠️ Tecnologias Utilizadas

- **C#**
- **MySQL**
- **Windows Forms / WPF** 
- **MySQL Connector for .NET**
- **Telegram.Bot API**

---

## 🚀 Como Executar

### 1. Clone o repositório
- git clone https://github.com/seu-usuario/UaiFood.git
- Alterar informações de configuração do MySql (user e senha) na classe BancoDados
- Para usar a API do Telegram:
  - Criar Bot no Telegram
  - Inserir token na classe TelegramController

## 🎓 Conceitos Trabalhados

- CRUD em C# com MySQL
- Relacionamentos entre tabelas (1:N)
- Integração com API externa (Telegram)
- Manipulação de interface gráfica em Windows Forms
- Organização em camadas (MVC simplificado)

