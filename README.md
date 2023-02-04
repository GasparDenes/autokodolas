# autokodolas
Egy autógyártó cég úgy szeretné kiosztani az autók gyártási kódjait, hogy a kódból egyértelmű-en meghatározható legyen az autó típusa. Azt találták ki, hogy az azonos típusú autók gyártási kódjainak kettes számrendszerbeli alakjában ugyanannyi 1-es bit legyen. Például a 3 (=112), az 5 (=1012) és a 6 (=1102) kódok mindegyikében kettő darab 1-es található. Tehát az első ilyen típusú autó a 3-as kódot kapja, a második az 5-öst, a harmadik pedig a 6-ost.
Készíts programot, amely megadja egy adott kódot közvetlenül megelőző és követő ugyanolyan típusú autók kódját!


Bemenet 
A standard bemenet első sorában a megadott kód van (1≤N≤1012).


Kimenet 
A standard kimenet első sorába a megadott kódot megelőző, a második sorába pedig a következő kódot kell írni! Ha valamelyik nem létezik, akkor a megfelelő sorba -1-et kell kiírni!

Példa
Bemenet	Kimenet
46	45
51
Magyarázat
46=101110	45=101101
51=110011
Bemenet	Kimenet
4294967296	2147483648
8589934592
