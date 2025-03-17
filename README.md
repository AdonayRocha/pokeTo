# Poketo 📱💰

**Poketo** é um projeto de exemplo que demonstra a implementação de uma aplicação de console em C# com uma biblioteca (*lib*) para gerenciamento de contas bancárias. O nome *Poketo* vem da combinação de "Poke" (de bolso) e "to" (para), significando **"Para Bolso"**. 🧳  

## 📂 Estrutura do Projeto  

O projeto é composto por dois componentes principais:  

### Projeto de Console  

- **Arquivo principal:** `Poketo.cs`  
- **Local:** Diretório principal do projeto  
- **Função:** Ponto de entrada do aplicativo console que utiliza os objetos da biblioteca.  

### Projeto de Biblioteca (*Lib*)  

- **Diretório:** `Lib`  
- **Arquivos:** `Conta.cs` e `ContaCorrente.cs`  
- **Função:** Contém as classes e lógica de negócios para gerenciamento de contas bancárias.  

## 🛠️ Requisitos Técnicos  

O projeto atende aos seguintes requisitos técnicos:  

### Implementação de todos os 7 níveis de acesso:  

- **`public`**: Propriedade `Titular` e métodos `Depositar`, `Sacar`, `ObterSaldo`.  
- **`private`**: Método `AtualizarSaldo`.  
- **`protected`**: Propriedade `Saldo`.  
- **`internal`**: Propriedade `Banco` e método `ExibirSaldo`.  
- **`protected internal`**: Propriedade `Agencia`.  
- **`private protected`**: Propriedade `NumeroConta`.  
- **`internal protected`**: Método `Transferir` na classe `ContaCorrente`.  

### Presença de pelo menos uma classe abstrata  

- A classe `Conta` é uma classe abstrata que define a estrutura básica de uma conta bancária.  

### Aplicação de polimorfismo utilizando `override`  

- A classe `ContaCorrente` utiliza `override` para implementar os métodos `Depositar` e `Sacar`.  

## 🚀 Como Funciona  

### **Classe Conta**  

- **Descrição:** Classe abstrata que define a estrutura básica de uma conta bancária.  

#### **Propriedades:**  
- `Titular`: Nome do titular da conta.  
- `Saldo`: Saldo da conta.  
- `Banco`: Nome do banco.  
- `Agencia`: Número da agência.  
- `NumeroConta`: Número da conta.  

#### **Métodos:**  
- `Depositar`: Método abstrato para depositar um valor na conta.  
- `Sacar`: Método abstrato para sacar um valor da conta.  
- `AtualizarSaldo`: Método privado para atualizar o saldo.  
- `ExibirSaldo`: Método `internal` para exibir o saldo.  
- `ObterSaldo`: Método público para obter o saldo.  

---

### **Classe ContaCorrente**  

- **Descrição:** Classe que herda de `Conta` e implementa os métodos abstratos.  

#### **Métodos:**  
- `Depositar`: Implementação do método abstrato para depositar um valor na conta.  
- `Sacar`: Implementação do método abstrato para sacar um valor da conta.  
- `Transferir`: Método `internal protected` para transferir um valor para outra conta corrente.  

---

### **Classe Program**  

- **Descrição:** Classe principal que contém o método `Main`, ponto de entrada do programa.  

#### **Método:**  
- `Main`: Cria uma instância de `ContaCorrente`, realiza operações de depósito e saque, e exibe o saldo.  

## 🏃‍♂️ Como Executar  

Para compilar e executar o projeto, siga os passos abaixo:  

1. **Compilar o projeto:**  
   ```sh
   dotnet build
