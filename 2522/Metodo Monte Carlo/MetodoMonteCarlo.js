var LimInferior = 0;
var LimSuperior = 0.16;

function Funcion1() {
    var Probabilidad = parseFloat(document.getElementById("ValorLados")).value;
    var Division = parseFloat(document.getElementById("ValorDivision")).value;

    if (Probabilidad == "" || Division == "")
    {
        alert("No ha ingresado ningun valor");
    }
    else {
        var RProb;

        RProb = Probabilidad + Division;
        alert(RProb);
        console.log(RProb);
    }
}
function click() {
    Funcion1();
}