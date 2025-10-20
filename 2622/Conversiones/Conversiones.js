function accion() {
    conversion();
}
function conversion() {
    let numero = document.getElementById("Numero").value;

    if (numero = "")
    {
        alert("No ha ingresado ningún valor");
    }
    else
    {
        console.log(Number(numero).toString(2));
        // document.getElementById("Resultado").value=(numero);
    }
}