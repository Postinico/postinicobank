# 💳 Prática de Design Pattern: Factory Method em C#

Esta branch é dedicada ao estudo e implementação do padrão de projeto criacional **Factory Method**. 

O objetivo do projeto é simular a emissão e processamento de operações (Débito e Crédito) em diferentes tipos de **cartões de crédito**, delegando a criação das instâncias para uma fábrica.

---

## 🎯 Conceito Aplicado

O **Factory Method** permite criar objetos sem expor a lógica de criação para o cliente. A escolha de qual classe concreta instanciar é tomada pela fábrica, facilitando a extensão do código caso novos cartões sejam adicionados no futuro (respeitando o princípio **Open/Closed** do SOLID).

---

## 🏗️ Arquitetura do Projeto

### 1. Interface Base (`ICartao`)
Define o contrato que todos os cartões concretos devem implementar.

Contém os métodos:
- `ObterTipo()`: Método de identificação usado pela Factory para reconhecer o tipo do cartão.
- `Debitar(decimal valor)`: Executa a operação de débito.
- `Creditar(decimal valor)`: Executa a operação de crédito.

### 2. Cartões Concretos
Implementações específicas da interface `ICartao`:
- 🖤 **`CartaoBlack`**: Regras de débito/crédito específicas para a categoria Black.
- 🩶 **`CartaoPlatinum`**: Regras específicas para a categoria Platinum.
- 👑 **`CartaoDuke`**: Regras e limites exclusivos para a categoria ultra-premium Duke.

### 3. Factory (`CartaoFactory`)
Classe responsável por ler o tipo de cartão solicitado e retornar a instância correta de `ICartao`.
