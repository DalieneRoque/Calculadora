# Calculadora 

## Este código é um exemplo simples de uma calculadora em C# que permite realizar operações aritméticas e, caso o usuário queira, repetir o processo até que decida encerrar.

### Entrada de Dados

* O programa solicita que o usuário digite dois números.
* Console.ReadLine() lê o que foi digitado como uma string.
* double.Parse() converte essa string para o tipo double, permitindo cálculos com números decimais.
~~~
Console.Write("Digite o primeiro número: ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double n2 = double.Parse(Console.ReadLine());
~~~

### Escolha da Operação

* O programa solicita que o usuário escolha uma operação.
* Aqui, char.Parse(Console.ReadLine()) converte o valor digitado em um caractere (char), que será usado para determinar a operação a ser realizada.
~~~
Console.WriteLine("Escolha a operação (+ - x /): ");
char op = char.Parse(Console.ReadLine());
~~~

### Estrutura de Decisão (switch)

* O switch verifica o valor do operador digitado e decide qual operação será realizada.
* Caso o operador digitado não seja reconhecido, o default é acionado, informando que a opção é inválida.
~~~
double resultado = 0;

switch (op)
{
    default:
        Console.WriteLine("Erro, opção inválida.");
        break;
~~~

### Casos válidos de operações:

### Soma
* Realiza a soma dos dois números.
~~~
case '+':
    resultado = n1 + n2;
    Console.WriteLine("O resultado da soma é: " + resultado);
    break;

~~~

### Subtração
* Realiza a subtração dos dois números.
~~~
case '-':
    resultado = n1 - n2;
    Console.WriteLine("O resultado da subtração é: " + resultado);
    break;

~~~

### Multiplicação
* Aqui, a multiplicação é executada, e o operador pode ser tanto x minúsculo quanto X maiúsculo.
~~~
case 'x':
case 'X':
    resultado = n1 * n2;
    Console.WriteLine("O resultado da multiplicação é: " + resultado);
    break;

~~~

### Divisão
* A divisão é realizada, mas antes o programa verifica se o divisor (n2) é zero. Se for, é exibida uma mensagem de erro, pois não se pode dividir por zero.
* Além do operador /, o código também aceita : como uma forma de divisão.
~~~
case '/':
case ':':
    if (n2 == 0)
    {
        Console.WriteLine("Não é possível dividir por 0");
    }
    else
    {
        resultado = n1 / n2;
        Console.WriteLine("O resultado da divisão é: " + resultado);
    }
    break;

~~~

### Repetição (goto)

* Após calcular o resultado, o programa pergunta ao usuário se deseja continuar.
* Se o usuário digitar s ou S, o comando goto Inicio; faz o programa voltar para o início, permitindo um novo cálculo.
* Se a resposta for diferente, o programa exibe a mensagem de fim e encerra.
~~~
Console.Write("Quer continuar calculando (s / n) ?");
char opcao = char.Parse(Console.ReadLine());

if (opcao == 's' || opcao == 'S')
{
    goto Inicio;
}
else
{
    Console.WriteLine("Fim do cálculo.");
}

~~~

### Finalização do Programa

* Aguarda que o usuário pressione uma tecla antes de fechar o programa, permitindo que ele veja o resultado final antes do encerramento.

~~~
Console.ReadKey();
~~~




