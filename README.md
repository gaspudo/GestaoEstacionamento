# 🚗 Gestão de Estacionamento POO
Sistema de controle de estacionamento desenvolvido em C# para consolidar conceitos avançados de Programação Orientada a Objetos (POO). O projeto simula a entrada de veículos, o cálculo de permanência e o processamento de pagamentos através de diferentes modalidades.

## 🎯 Objetivos do Projeto
Este projeto foi construído com o foco em criar uma arquitetura rígida e extensível, aplicando os quatro pilares da POO e princípios de design de software:

### Abstração:
Uso de classes abstratas para definir a identidade de Veiculo.

### Herança: 
Especialização de veículos em Carro e Moto.

### Encapsulamento: 
Proteção de propriedades sensíveis e regras de negócio internas.

### Polimorfismo: 
Implementação de diferentes lógicas de cálculo e de pagamento através de métodos sobrescritos e interfaces.

## 🏗️ Arquitetura do Sistema
### 1. Módulo de Veículos
A classe base Veiculo gerencia os dados comuns (Placa, Marca, Modelo) e define o contrato para o cálculo de valores.

Carro: Valor inicial de R$ 12,00.

Moto: Valor inicial de R$ 7,00.

### 2. Módulo Financeiro (Interfaces)
Utilização da interface IPagamento para garantir que o sistema de caixa seja independente do método de pagamento escolhido:

Cartão: Aplicação automática de taxa administrativa de 2%.

Dinheiro: Lógica de fluxo de caixa com validação de montante entregue e cálculo de troco.

PIX: Geração de chave aleatória via Guid para transações instantâneas.

## 🛠️ Tecnologias Utilizadas
.NET 8 / C#

LINQ (para futuras implementações de busca)

Manipulação de Tipos Nullable (Tratamento de erro CS8600)

## 🚀 Como Executar
Clone o repositório.

Certifique-se de ter o SDK do .NET instalado.

No terminal, execute:
"dotnet run"

## 📝 Lições Aprendidas
"A complexidade da POO não está em escrever classes, mas em definir contratos que permitam ao sistema crescer sem a necessidade de modificar o que já funciona."

Durante o desenvolvimento, foquei em eliminar o uso excessivo de condicionais (if/else) no fluxo principal, delegando as decisões para o comportamento natural dos objetos (Polimorfismo).
