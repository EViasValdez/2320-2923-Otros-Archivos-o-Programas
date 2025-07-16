var total = [];
////////////////
// Aqui van las funciones. //
function AgreCarro1() {
    var BotonElement = document.getElementById("boton1");
    var PElement = document.getElementById("uno");
    var Contador = 0;
    BotonElement.onclick = function () {
        Contador++;
        PElement.textContent = Contador;
        
        var Los3 = parseInt(document.getElementById('numero1').value);
        total.push(Los3);
    }
}

function AgreCarro2() {
    var BotonElement = document.getElementById("boton2");
    var PElement = document.getElementById("uno");
    var Contador = 0;
    
    BotonElement.onclick = function () {
        Contador++;
        PElement.textContent = Contador;
        var Los3 = parseInt(document.getElementById('numero2').value);
        
        total.push(Los3);
    }
}

function AgreCarro3() {
    var BotonElement = document.getElementById("boton3");
    var PElement = document.getElementById("Dos");
    var Contador = 0;
    
    BotonElement.onclick = function () {
        Contador++;
        PElement.textContent = Contador;
        var Los3 = parseInt(document.getElementById('numero3').value);
        total.push(Los3);
    }
}

function AgreCarro4() {
    var BotonElement = document.getElementById("boton4");
    var PElement = document.getElementById("dos");
    var Contador = 0;
    
    BotonElement.onclick = function () {
        Contador++;
        PElement.textContent = Contador;
        var Los3 = parseInt(document.getElementById('numero4').value);
        
        total.push(Los3);
    }
}

function Calcular() {
    let Uno = document.getElementById("uno");
    let monitorValue = parseInt(uno.innerHTML);
    
    let Dos = document.getElementById("Dos");
    var DosValue = parseInt(Dos.innerHTML);
    
    let Sum = 0;
    
    for (let index = 0; index < total.length; index++) {
        Sum += total[index];
    }
    document.getElementById("resultado").value = Sum;
}
