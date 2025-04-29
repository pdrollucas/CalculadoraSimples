# 📟 Calculadora Simples

**Desenvolvido por:** Eduardo Correa e Pedro Lucas Luckow

---

## 📄 Descrição

Uma calculadora simples de console desenvolvida em C# .NET 8.0, capaz de realizar as quatro operações básicas (soma, subtração, multiplicação e divisão). Além disso, permite ao usuário visualizar o histórico de seus últimos quatro cálculos e o histórico completo.

---

## 🛠 Tecnologias

- C# .NET 8.0

---

## ✅ Requisitos Funcionais

- **RF01**: Realizar operações matemáticas básicas com dois números decimais.  
- **RF02**: Validar entradas inválidas (não numéricas) e operações impossíveis (ex: divisão por zero).  
- **RF03**: Manter histórico das **últimas 4 operações** realizadas.  
- **RF04**: Permitir visualizar o **histórico** de operações.  
- **RF05**: Permitir **limpar o histórico** de operações.  
- **RF06**: Exibir mensagens de erro claras para operações inválidas.  
- **RF07**: Aceitar números decimais com **ponto ou vírgula** como separador.

---

## 📌 Requisitos Não Funcionais

- **RNF01**: Interface intuitiva com mensagens claras em **português**.  
- **RNF02**: Tratamento adequado de erros sem interrupções.  
- **RNF03**: Código comentado em partes complexas e seguindo convenções **C#**.

---

## 🧪 Casos de Teste

| Código | Descrição |
|--------|-----------|
| **CT01** | Verificar se o resultado da operação está correto. |
| **CT02** | Exibir mensagem de erro ao tentar **dividir por zero**. |
| **CT03** | Verificar se apenas as **últimas 4 operações** são mostradas após 5 operações. |
| **CT04** | Validar soma com **formatos diferentes** de decimal: `1.5 + 2,5 = 4`. |
| **CT05** | Exibir mensagem de erro ao realizar uma **operação inválida**. |

---

## 📊 Diagrama de Casos de Uso

![calculadora - diagrama de caso de uso](https://github.com/user-attachments/assets/59feaa1c-9835-42eb-b5ca-493fe6bdb550)


---

## 📦 Diagrama de Classe

![calculadora - diagrama de classe](https://github.com/user-attachments/assets/bc0c6815-3177-4e8e-bedb-e76f7c3d5600)


---

## 🚀 Como Utilizar

1. Clone o repositório:
   ```bash
   git clone https://github.com/pdrollucas/CalculadoraSimples.git
2. Abra o projeto no Visual Studio 2022+
3. Compile e execute o programa
