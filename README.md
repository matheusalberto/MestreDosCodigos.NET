# MestreDosCodigos.NET
Repositório com a resolução das questões de Nível Escudeiro .NET do Mestre dos Códigos.

Aqui serão listadas todas as questões, suas respostas (perguntas teóricas) e suas instruções de execução (se necessário).

## Perguntas teóricas de introdução

1. Em quais linguagens o C# foi inspirado?
_O C# foi baseada nas linguagens de programação C, C++ e Java. Em relação a linguagem C, o C# tem foco na compilação de soluções de alto nível, já a linguagem C é voltada para o desenvolvimento de baixo nível. Outras comparações, de acordo com MSDN (2012), o C#, simplifica de modo significativo a complexidade do C++ e introduz novos elementos não disponíveis no Java, tais como: tipos primitivos com valores nulos, delegações, expressões lambda e acesso direto à memória._

2. Inicialmente o C# foi criado para qual finalidade?
_O C# surgiu com a finalidade de possibilitar a criação de soluções executáveis sobre a plataforma .NET Framework, com o intuito de flexibilizar o desenvolvimento de aplicativos. Dessa maneira, o desenvolvedor não cria soluções para um dispositivo eletrônico específico, e sim para a plataforma .NET Framework._

3. Quais os principais motivos para a Microsoft ter migrado para o Core?
_Diferentemente do .Net Framework, o .NET Core é multiplataforma. Possui alta performance e sistemas escaláveis. O .NET Core tem um intuito do uso de microsserviços e possuir maior modularidade para o uso de containeres._

4. Cite as principais diferenças entre .Net Full Framework e .Net Core.
* _Modelos de aplicativos - .NET Core não dão suporte a todos os .NET Framework modelos de aplicativos. Ele não dá suporte especificamente a Web Forms do ASP.NET e a ASP.NET MVC, mas dá suporte ao ASP.NET Core MVC. E, a partir do .NET Core 3,0, o .NET Core também oferece suporte ao WPF e Windows Forms somente no Windows._
* _APIs - o .NET Core contém um grande subconjunto da biblioteca de classes base .NET Framework, com aspectos diferentes (os nomes de assembly são diferentes, os membros expostos nos tipos são diferentes em casos principais). Em alguns casos, essas diferenças exigem alterações na origem da porta para o .NET Core._
* _Subsistemas - O.NET Core implementa um subconjunto dos subsistemas no .NET Framework com o objetivo de proporcionar uma implementação e um modelo de programação mais simples._
* _Plataformas - Suporte para macOS e Linux_
* _Software Livre - Todo .NET Core é um software livre_

## Trabalhando no Console

1. Crie uma aplicação, que receba os valores A e B. Mostre de forma simples, como utilizar variáveis e manipular dados.
* Some esses 2 valores;
* Faça uma subtração do valor A - B;
* Divida o valor B por A;
* Multiplique o valor A por B;
* Imprima os valores de entrada, informado se o número é par ou impar;
* Imprima todos os resultados no console, de forma que o usuário escolha a ação desejada.

2. Crie uma aplicação que receba nome e salario de N funcionários. Utilize a repetição for e while.
* Imprima o maior salario
* Imprima o menor salario.

3. Faça uma aplicação que imprima todos os múltiplos de 3, entre 1 e 100. Utilize a repetição while.

4. Faça uma aplicação que receba N alunos com suas respectivas notas. Use foreach para estrutura de repetição.
* Crie um objeto alunos
* Armazene os alunos em uma lista.
* Imprima todos os alunos com medias superiores a 7.

5. Crie uma aplicação que calcule a fórmula de Bhaskara.
* Receba os valores a,b,c.
* Imprima os resultados R1 e R2.
* Use a biblioteca MATH.

6. Crie uma aplicação, que demonstre a diferença entre REF e OUT.

7. Faça uma aplicação ler 4 números inteiros e calcular a soma dos que forem pares.

8. Faça uma aplicação ler N valores decimais, imprima os valores em ordem crescente e decrescente.

9. Utilizando a biblioteca LINQ crie no console e execute:
* Crie uma lista que receba inteiros.
* Imprimir todos os números da lista.
* Imprimir todos os números da lista na ordem crescente.
* Imprimir todos os números da lista na ordem decrescente.
* Imprima apenas o primeiro número da lista
* Imprima apenas o ultimo número da lista
* Insira um numero no inicio da lista.
* Insira um numero no final da lista.
* Remova o primeiro número .
* Remova o ultimo número .
* Retorne apenas os número pares.
* Retorne apenas o número informado.
* Transforme todos os numero da lista em um array.

## Utilizando POO

1. Responda e demonstre no código os itens abaixo:
* O que é POO?
Programação Orientada a Objetos. É um padrão de desenvolvimento que é seguidos por muitas linguagens como C# e Java. E outras palavras, POO é um paradigma de programação baseado no conceito de objetos, que contém dados na forma de campos (atributos) e procedimentos na forma de métodos. Tais objetos podem interagir entre si.
* O que é polimorfismo?
É um princípio a partir do qual as classes derivadas de uma única classe base são capazes de invocar métodos que, embora apresentem a mesma assinatura, comportam-se de maneira diferente para cada uma de suas classes derivadas.	
Por exemplo, temos 3 contas, ContaA, ContaB e ContaC, e cada uma tem uma Taxa diferente. Sendo assim, todas as contas derivariam da classe Taxa, e implementariam da maneira mais cabível o cálculo da taxa. 
* O que é abstração?
Abstração é a habilidade de concentrar nos aspectos essenciais de um contexto qualquer, ignorando características menos importantes ou acidentais. No aspecto de POO, uma classe abstrata é desenvolvida para representar entidades e conceitos abstratos. A classe abstrata é sempre uma superclasse que não possui instâncias. Ela define um modelo (template) para uma funcionalidade e fornece uma implementação incompleta - a parte genérica dessa funcionalidade - que é compartilhada por um grupo de classes derivadas. Cada uma das classes derivadas, completa a funcionalidade da classe abstrata adicionando um comportamento específico.	
É utilizada para a definição de entidades do mundo real. Sendo onde são criadas as classes. Essas entidades são consideradas tudo que é real, tendo como consideração as suas características e ações.
* O que é encapsulamento?
É a técnica utilizada para esconder uma ideia, ou seja, não expôr detalhes internos para o usuário, tornando partes do sistema mais independentes possível. Por exemplo, quando um controle remoto estraga apenas é trocado ou consertado o controle e não a televisão inteira. Em POO, utiliza-se atributos privados, e getters e setters para acessar os mesmos.
* Quando usar uma classe abstrata e quando devo usar uma interface?
Uma interface não possui implementação, apenas assinatura. A interface indica o que deve ser implementado. É como se fosse um contrato, que indica o que deve ser cumprido. Já as classes abstratas servem como uma classe base, que pode conter atributos e métodos completos. Porém, um ou mais destes métodos devem ser incompletos.
* O que faz as interfaces IDisposable, IComparable, ICloneable e IEnumerable?
IDisposable: Fornece um mecanismo para liberar recursos não gerenciados.
IComparable: Define um método de comparação de tipo específico generalizado que implementa uma classe ou um tipo de valor para solicitar ou classificar suas instâncias.
ICloneable: Dá suporte à clonagem, que cria uma nova instância de uma classe com o mesmo valor de uma instância existente.
IEnumerable: Expõe um enumerador que dá suporte a uma iteração simples em uma coleção não genérica.
* Existe herança múltipla (de classes) em C#?
Não

2. Crie uma classe para representar uma pessoa
* Crie os atributos privados de nome, data de nascimento e altura.
* Crie os métodos públicos necessários para sets e gets e também um método para imprimir todos dados de uma pessoa.
* Crie um método para calcular a idade da pessoa.
* Imprima os dados via console.

3. Faça uma aplicação bancaria.
* Crie uma classe abstrata Conta Bancaria que contém como atributos, numero da conta e o saldo, e como métodos abstratos sacar e * depositar que recebem um parâmetro do tipo double.
* Crie as classes Conta Corrente e Conta Especial que herdam da Conta Bancaria.
* A Conta Corrente possui um atributo taxaDeOperação que é descontado sempre que um saque e um depósito são feitos.
* A Conta Especial possui um atributo limite que dá credito a mais para o correntista caso ele precise sacar mais que o saldo. Neste * caso, o saldo pode ficar negativo desde que não ultrapasse o limite. Contudo isso não pode acontecer na classe Conta Corrente.
* Crie uma interface Imprimível que declara um método MostrarDados, implemente em ambas contas e imprima os dados em cada uma.
* Via console, abra 2 contas de cada tipo execute todas as operações.

4. Crie uma classe Televisão e uma classe ControleRemoto que pode controlar o volume e trocar os canais da televisão. O controle de volume permite:
* Aumentar ou diminuir a potência do volume de som em uma unidade de cada vez.
* Aumentar e diminuir o número do canal em uma unidade.
* Trocar para um canal indicado.
* Consultar o valor do volume de som e o canal selecionado.
* Imprima os dados via console.

## Trabalhando com testes

1. Quais os principais frameworks que podemos usar no desenvolvimento de testes?
* [xUnit.NET]
* NUnit
* [MSTest]

2. Escolha dois frameworks e faça testes unitários para pelo menos dois exercícios em cada framework.

## BONUS

1. Utilizando qualquer exercício, execute-o no Linux.