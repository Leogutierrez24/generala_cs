using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Juego
{
    public partial class Reglas_frm : Form
    {
        public Reglas_frm()
        {
            InitializeComponent();
        }

        private void Reglas_frm_Load(object sender, EventArgs e)
        {
            string texto = "La generala es un juego de dados. Se juega con cinco dados y un cubilete; el número de jugadores es ilimitado, pero lo ideal es de 3 a 5. El objetivo del juego es lograr la mayor puntuación, de acuerdo a la valoración establecida para cada jugada posible en el juego, llamada categoría.\r\n\r\nJuego y puntuaciones\r\n--------------------\r\nHay varias formas de decidir quién inicia el juego; una puede ser que cada jugador tire un dado, y el que obtenga el número más alto será el que comience.1​ Otra es que cada jugador tire los cinco dados, y el que obtenga la suma más baja es el que iniciará el juego. Por otra parte, el que quede en segundo lugar se sentará a su izquierda y así sucesivamente.2​ El orden del juego sigue la dirección de la mano derecha, en sentido contrario al del las agujas del reloj.\r\n\r\nExisten 10 posibles categorías, por lo que cada jugador tendrá 11 tiros posibles en el juego. Cada tirada consiste en el lanzamiento de los cinco dados,1​ y según sean los números que salgan se podrá optar a una categoría; si no se logra alcanzar una categoría satisfactoria en el primer lanzamiento se pueden apartar los dados útiles y tomar los demás y tirarlos de nuevo; en esta segunda tirada se pueden apartar otra vez los más convenientes y juntarlos con los que ya tenía apartados, y luego se tirará el resto por tercera y última vez, con lo que termina la tirada. Si en un solo tiro se logró una categoría, a esto se lo llama «tiro servido» (sólo se aplicará para los juegos mayores; ver más adelante). Esto sólo puede ocurrir en el primero de los tres tiros de cada turno.3​ La puntuación se establece en relación con la categoría que se obtiene con la combinación de los 5 dados.\r\n\r\nPara anotar la puntuación de cada jugador se debe preparar una planilla anotando en filas las once categorías posibles, que van de la categoría 1 a la 6 y luego las categorías que se llaman \"Juegos mayores\", que son escalera, full, póker, generala y doble generala (esta última se puede omitir con el acuerdo de los jugadores, con lo que entonces serían diez categorías y serían diez tiros por jugador). En los encabezados, formando columnas verticales, se colocan los nombres de los jugadores.\r\n\r\nCategorías\r\n----------\r\nPara calcular el puntaje correspondiente a una categoría de números del 1 al 6, se deben sumar los números iguales. Por ejemplo, si un jugador, tirara tres dados con el número 6, se sumará, 6+6+6=18, este resultado se anotará en la casilla correspondiente al número 6. Si son tres 1 se debe anotar 3 al 1, si hay dos 6 se debe anotar 12 al 6.\r\n\r\n° 1: se coloca el número que dé la suma de 1 obtenidos.\r\n° 2: se coloca el número que dé la suma de 2 obtenidos.\r\n° 3: se coloca el número que dé la suma de 3 obtenidos.\r\n° 4: se coloca el número que dé la suma de 4 obtenidos.\r\n° 5: se coloca el número que dé la suma de 5 obtenidos.\r\n° 6: se coloca el número que dé la suma de 6 obtenidos.\r\n° Escalera: 25 puntos si es servida, 20 si fue armada. Se forma con una progresión de números. Hay tres posibilidades: 1-2-3-4-5 (escalera menor), 2-3-4-5-6 (escalera   mayor) o 3-4-5-6-1\r\n° Full: 35 puntos si es servido o 30 puntos si es armado. Se forma con dos grupos de dados iguales, uno de tres y otro de dos dados.\r\n° Póker: 45 puntos si es servido o 40 puntos si es armado. Se forma con cuatro dados iguales.\r\n° Generala: 60 puntos (o 50 puntos, según la variante) si se logra formar cinco números iguales en dos o tres tiros.\r\n° Generala Doble o Servida: Cuando se logra la Generala de un solo tiro, se llama generala servida y en cualquier tiro se gana la partida.\r\n\r\nNotas\r\n-----\r\nUna vez lograda una categoría esta se considera \"Cerrada\", es decir, si el jugador la repite no la podrá usar, de tal forma que tendrá que buscar otra posible categoría con la combinación de dados obtenida. Por ejemplo, si el jugador tira 4-4-2-2-2, si ya había anotado el full, puede anotar la tirada en la categoría del 4 o del 2.\r\n\r\nNingún jugador está obligado a elegir una categoría hasta que él decida o hasta su tercer tiro. De tal forma que si un jugador hace en su primer tiro un \"juego mayor\", puede arriesgarse si quiere a intentar otra categoría tomando inclusive los cinco dados. Luego que un dado ha sido apartado no se lo puede volver a usar.\r\n\r\nSi al terminar una tirada el jugador no puede armar un juego conveniente en ninguna de sus categorías abiertas, deberá elegir alguna y tachar la casilla correspondiente, con lo que quedará cerrada.\r\n\r\nCuando se han completado las once vueltas del juego (o diez según si así se decidió), se sumarán los puntos.";
            Reglas_textBox.Text = texto;
        }
    }
}
