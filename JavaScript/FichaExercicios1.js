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
      
      default: console.log("Opção inválida!");
    }
    readline.close();
  });
}

menu();
