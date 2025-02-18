"use strict";
const DIM = 3;
let nSegreti = []; 
init();

function init()
{
    for(let i = 0; i < DIM; i++)
    {
        let n = 0;
        do
        {   
            n = generaNumero(1,10);
        }while(nSegreti.includes(n));
        nSegreti.push(n);
    }
    console.log(nSegreti);
}
function generaNumero(min,max)
{
    return Math.floor((max-min)*Math.random())+min;
}