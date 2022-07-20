let data: number | string;

data = '42';
data = 10;
interface ICar
{
    color:string,
    model:string;
    topSpeed?:100
}

const car1:ICar = {
    color: 'blue',
    model: 'mercedes'
};
const car2:ICar = {
    color: 'blue',
    model: 'mercedes',
    topSpeed: 100
};

const multiply = (x:number,y:number):string=>{
    return (x*y).toString();
};