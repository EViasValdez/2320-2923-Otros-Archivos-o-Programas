var LimInferior = 0;
var LimSuperior = 0.16;

function funcion1(){
    var probabilidad = parseFloat(document.getElementById("ValorLados")).value;
    var division = parseFloat(document.getElementById("ValorDivision")).value;

    if (probabilidad == "" || division == ""){
        alert("No ha ingresado ningun valor");
    }
    else{
        var rprob;

        rprob = probabilidad + division;
        alert(rprob);
        console.log(rprob);
    }
}
function click(){
    funcion1();
}