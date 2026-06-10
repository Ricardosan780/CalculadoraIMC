# 🧮 Calculadora de IMC em ASP.NET Core Core MVC

Esta aplicação foi desenvolvida para realizar o cálculo do Índice de Massa Corporal (IMC) diretamente no lado do servidor (Server Side) utilizando C# e o framework ASP.NET MVC.

## 🚀 O que foi programado

- **Model (`ImcModel.cs`):** Define os dados de entrada do usuário (`Peso` e `Altura`) aplicando validações nativas com Data Annotations para garantir que valores vazios ou absurdos não quebrem o sistema. Também armazena as propriedades de resposta retornadas pelo servidor.
- **Controller (`ImcController.cs`):** Contém os métodos HTTP. O método `POST` recebe o objeto da Model preenchido pelo formulário, executa a fórmula matemática do IMC e aplica estruturas condicionais (`if/else`) para determinar a faixa de classificação do peso corporal.
- **View (`Index.cshtml`):** Interface limpa construída com Razor View Engine e Tag Helpers (`asp-for`), utilizando quebras de linha corretas para evitar o empilhamento horizontal de componentes, exibindo as validações de erro em tempo real e um bloco dinâmico que renderiza o resultado assim que o processamento do servidor é concluído.

## 📷 Demonstração da Aplicação Rodando

> **Abaixo está o registro visual do sistema em execução:**

![Print da Aplicação Rodando](print-aplicacao.png)