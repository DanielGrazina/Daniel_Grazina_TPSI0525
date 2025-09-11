// Exercício 1
function exercicio1() {
  let pares = [], impares = [];
  for (let i = 1; pares.length < 30 || impares.length < 30; i++) {
    if (i % 2 === 0 && pares.length < 30) pares.push(i);
    if (i % 2 !== 0 && impares.length < 30) impares.push(i);
  }
  console.log("30 primeiros pares:", pares.join(", "));
  console.log("30 primeiros ímpares:", impares.join(", "));
}

// Exercício 2
function exercicio2() {
  let numeros = [12, 7, 5, 8, 20, 15, 3, 6, 14, 9];
  numeros.forEach(num => console.log(num, num % 2 === 0 ? "é PAR" : "é ÍMPAR"));
}

// Exercício 3
function exercicio3() {
  let notas = [12, 15, 14, 10, 18, 20, 16, 13, 11, 17];
  let soma = notas.reduce((acc, n) => acc + n, 0);
  console.log("Média:", (soma / notas.length).toFixed(2));
}

// Exercício 4
function ehPrimo(n) {
  if (n <= 1) return false;
  for (let i = 2; i <= Math.sqrt(n); i++) if (n % i === 0) return false;
  return true;
}
function exercicio4() {
  let numero = 29;
  console.log(numero, ehPrimo(numero) ? "é primo" : "não é primo");
}

// Exercício 5
function exercicio5() {
  for (let i = 1; i <= 10000; i++) console.log(i);
}

// Exercício 6
function exercicio6() {
  let primos = [];
  for (let i = 2; primos.length < 10; i++) if (ehPrimo(i)) primos.push(i);
  console.log("10 primeiros primos:", primos.join(", "));
}

// Exercício 6
function exercicio7() {
  let serie = [];
  for (let i = 10; i <= 1000; i += 10) serie.push(i);
  console.log("Série:", serie.join(", "));
}

// Exercício 8
function exercicio8() {
  let serieA = [], serieB = [];
  for (let i = 10; i <= 1000; i += 10) serieA.push(i);
  for (let i = 15; i <= 995; i += 10) serieB.push(i);
  console.log("Série A:", serieA.join(", "));
  console.log("Série B:", serieB.join(", "));
}

// Exercício 9
function exercicio9() {
  let valor;
  do {
    valor = Math.floor(Math.random() * 150);
  } while (valor < 1 || valor > 100);
  console.log("Número válido:", valor);
}

// Exercício 10
function divisores(n) {
  let divs = [];
  for (let i = 1; i <= n; i++) if (n % i === 0) divs.push(i);
  return divs;
}
function exercicio10() {
  let num = 28;
  console.log(`Divisores de ${num}:`, divisores(num).join(", "));
}

// Exercício 11
function exercicio11() {
  for (let i = 1; i <= 5; i++) console.log(String(i).repeat(i));
}

// Exercício 12
function exercicio12() {
  let n = 10, contagem = 0;
  for (let i = 1; i < n; i++) {
    console.log(`${n} + ${i} =`, n + i);
    console.log(`${n} - ${i} =`, n - i);
    console.log(`${n} * ${i} =`, n * i);
    console.log(`${n} / ${i} =`, (n / i).toFixed(2));
    contagem += 4;
  }
  console.log("Total de operações:", contagem);
}

// Exercício 13
function exercicio13() {
  let tab = 7;
  for (let i = 1; i <= 10; i++) console.log(`${tab} x ${i} = ${tab * i}`);
}

// Exercício 14
function exercicio14() {
  for (let t = 1; t <= 100; t++) {
    console.log(`\nTabuada do ${t}`);
    for (let i = 1; i <= 10; i++) console.log(`${t} x ${i} = ${t * i}`);
  }
}

// Exercício 15
function exercicio15() {
  let linha = "";
  for (let i = 0; i <= 255; i++) {
    linha += `${i}:${String.fromCharCode(i)}\t`;

    // a cada 20 valores, imprime e limpa a linha
    if ((i + 1) % 20 === 0) {
      console.log(linha);
      linha = "";
    }
  }

  // imprime o que sobrar (se não for múltiplo de 20 exato)
  if (linha !== "") console.log(linha);
}

// Exercício 16
function exercicio16() {
  let pares50 = [];
  while (pares50.length < 30) {
    let num = Math.floor(Math.random() * 50) + 1;
    if (num % 2 === 0) pares50.push(num);
  }
  let media = pares50.reduce((a, b) => a + b, 0) / pares50.length;
  console.log("Média de 30 pares entre 1 e 50:", media.toFixed(2));
}

// Exercício 17
function exercicio17() {
  let mult5 = [];
  for (let i = 1; i <= 1000; i++) if (i % 5 === 0 && i % 3 !== 0) mult5.push(i);
  console.log("Múltiplos de 5 não múltiplos de 3:", mult5.join(", "));
}

// Exercício 18
function ehPerfeito(n) {
  let soma = 0;
  for (let i = 1; i < n; i++) if (n % i === 0) soma += i;
  return soma === n;
}
function exercicio18() {
  let perfeitos = [];
  for (let i = 1; i <= 1000; i++) if (ehPerfeito(i)) perfeitos.push(i);
  console.log("Números perfeitos até 1000:", perfeitos.join(", "));
}

// Exercício 19
function exercicio19() {
  let fib = [1, 1];
  while (fib.length < 60) fib.push(fib[fib.length - 1] + fib[fib.length - 2]);
  console.log("60 primeiros Fibonacci:", fib.join(", "));
}

// Menu
function menu() {
  console.log("\nEscolha o número do exercício (1 a 19):");

  const readline = require("readline").createInterface({
    input: process.stdin,
    output: process.stdout
  });

  readline.question("Exercício: ", (opcao) => {
    switch (parseInt(opcao)) {
      case 1: exercicio1(); break;
      case 2: exercicio2(); break;
      case 3: exercicio3(); break;
      case 4: exercicio4(); break;
      case 5: exercicio5(); break;
      case 6: exercicio6(); break;
      case 7: exercicio7(); break;
      case 8: exercicio8(); break;
      case 9: exercicio9(); break;
      case 10: exercicio10(); break;
      case 11: exercicio11(); break;
      case 12: exercicio12(); break;
      case 13: exercicio13(); break;
      case 14: exercicio14(); break;
      case 15: exercicio15(); break;
      case 16: exercicio16(); break;
      case 17: exercicio17(); break;
      case 18: exercicio18(); break;
      case 19: exercicio19(); break;
      default: console.log("Opção inválida!");
    }
    readline.close();
  });
}

menu();
