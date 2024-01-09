using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone(numero: "11-11111111", modelo: "Modelo 1", imei: "AAAAAAAAAAAAA", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("aplicativo 1");

Nokia nokia = new Nokia(numero: "22-2222222222", modelo: "Modelo 2", imei: "BBBBBBBBBBBBB", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("aplicativo 2");