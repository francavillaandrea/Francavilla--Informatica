"use strict";


function lanciaMoneta(){
    let _txtLanci = document.getElementById(txtLanci);
    let cntTesta = 0;
    let cntCroce = 0;
    let nLanci = parseInt(_txtLanci.value);
    for(let i=0;i<nLanci;i++)
    {
        let nCas = generaNumero(0,2);
        if(nCas == 0)
            cntCroce++;
    }

}
function generaNumero(min,max){
    //formula per generare un numero 
    //casuale compreso tra min e max max escluso
    let n = Math.floor((max-min)*Math.random()+min);
    return n;    
}
