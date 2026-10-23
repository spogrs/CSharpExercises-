## Løkker


### multiplikationstabel

I `Main`-metoden skal du udskrive en multiplikationstabel, som vist nedenfor:

```
   1   2   3   4   5   6   7   8   9  10
   2   4   6   8  10  12  14  16  18  20
   3   6   9  12  15  18  21  24  27  30
   4   8  12  16  20  24  28  32  36  40
   5  10  15  20  25  30  35  40  45  50
   6  12  18  24  30  36  42  48  54  60
   7  14  21  28  35  42  49  56  63  70
   8  16  24  32  40  48  56  64  72  80
   9  18  27  36  45  54  63  72  81  90
  10  20  30  40  50  60  70  80  90 100
```

For eksempel står der i række 4 og kolonne 9 tallet 4 · 9 = 36.

Brug to indlejrede `for`-løkker til at løse opgaven. Bemærk, at `Console.WriteLine` automatisk starter en ny linje efter teksten, mens `Console.Write` ikke gør:

csharp

```csharp
Console.Write("tekst");
Console.WriteLine("mere tekst");
```

```
tekstmere tekst
```

Udskriv tallene i et felt med bredden fire, så de står pænt på linje. Feltbredden kan angives direkte i en interpoleret streng, f.eks. `$"{tal,4}"`, som højrestiller `tal` i et felt på fire tegn. Læs mere om dette i Microsofts dokumentation under [Composite formatting – alignment](https://learn.microsoft.com/dotnet/standard/base-types/composite-formatting#alignment-component).


### To terninger

Lad os se på kast med to terninger. (En terning kan vise en værdi mellem 1 og 6.) \
Brug to indlejrede for-løkker i Main-metoden til at gennemløbe alle de mulige kombinationer, 
som de to terninger kan give. Der er 36 mulige kombinationer.

Udskriv alle de kombinationer, hvor summen er 5, som (ordnede) par. \
Udskriften skal for eksempel indeholde parret `(2,3)`. \
Udskriv ét par pr. linje.

## Funktioner

### Øvelse 6 (tredobbelt og kvadrat)

Skriv to metoder: `Tredobl` og `Kvadrat`. 
Metoden `Tredobl` ganger sin parameter med tre. 
Metoden `Kvadrat` opløfter sin parameter i anden potens. 
Det vil sige at, hvis paramtren f.eks. hedder $x$, så returneres $x^2$,  som jo er det samme som $x*x$.  
For eksempel gælder `Tredobl(5) == 15` og `Kvadrat(5) == 25`.

**Del 1**

I `Main`-metoden skal du skrive en `for`-løkke, der gennemløber værdierne 1 til 10 og for hver værdi udskriver dens tredobling og dens kvadrat. Output skal se sådan ud:

```
Tredobl(1)==3 Kvadrat(1)==1
Tredobl(2)==6 Kvadrat(2)==4
...
```

**Del 2**

Ret nu løkken, så den stopper, når kvadratet af en værdi er større end tredoblingen af værdien. Der må ikke udskrives noget i det sidste gennemløb.

Bemærk, at hver af metoderne `Tredobl` og `Kvadrat` skal kaldes præcis én gang pr. gennemløb. Gem derfor resultaterne i variabler.

### Øvelse 7 (arealer af figurer)

Lav et program, der kan beregne arealet af tre figurer – trekanter, rektangler og cirkler – når deres mål er givet.

En uendelig løkke (`while (true)`) skal spørge, hvilken figur arealet skal beregnes for. En tom streng som input afslutter løkken. Hvis brugeren skriver noget, der ikke er en af figurerne, skal beskeden ”Ukendt figur!” udskrives. Ellers spørger programmet efter målene for den valgte figur. Når alle mål er givet, udskrives arealet, og løkken starter forfra. Udskriv arealet med seks decimaler ved hjælp af formatspecifikationen `F6`, f.eks. `$"{areal:F6}"`.

Læs input med `Console.ReadLine()`, og konverter tal med `double.Parse`. Hvad sker der, hvis du indtaster forkerte mål, f.eks. strengen ”aa” som radius? Du behøver ikke at håndtere fejl i input.

På en computer med danske indstillinger skrives decimaltal med komma, både når de indtastes, og når de udskrives.

Eksempel på en kørsel:

```
Vælg en figur (trekant, rektangel, cirkel): trekant
Angiv grundlinjen for trekanten: 20
Angiv højden for trekanten: 5
Arealet er 50,000000
Vælg en figur (trekant, rektangel, cirkel): rektangl
Ukendt figur!
Vælg en figur (trekant, rektangel, cirkel): rektangel
Angiv bredden for rektanglet: 20
Angiv højden for rektanglet: 4
Arealet er 80,000000
Vælg en figur (trekant, rektangel, cirkel): cirkel
Angiv radius for cirklen: 10
Arealet er 314,159265
Vælg en figur (trekant, rektangel, cirkel): 
```

## Datastrukturer: lister, tupler og ordbøger

### Øvelse 9 (fletning)

Antag, at vi har to lister `l1` og `l2` af typen `List<int>`, som indeholder heltal sorteret i stigende rækkefølge. Lav en metode `Flet`, der får de to lister som parametre og returnerer en ny sorteret liste `l`, som indeholder alle elementerne fra `l1` og `l2`. Altså skal `l.Count` være lig med `l1.Count + l2.Count`.

Udnyt, at begge lister allerede er sorteret. Du må ikke bruge `Sort`-metoden eller LINQ-metoder som `OrderBy` i `Flet`. Du må dog gerne bruge dem i `Main` til at lave input til `Flet`.

Test med et par eksempler i `Main`, at din løsning virker korrekt. En liste kan udskrives med `Console.WriteLine(string.Join(", ", l));`.

**Bemærk:** En liste i C# er en referencetype. Når du giver en liste som argument til en metode, får metoden en reference til den samme liste – listen bliver ikke kopieret! Sørg for ikke at ændre de oprindelige lister.

### Øvelse 10 (find intervaller)

Lav en metode `FindIntervaller`, der får en liste af heltal (`List<int>`) som parameter. Metoden skal

- sortere tallene (brug en kopi, så den oprindelige liste ikke ændres), og
- finde alle intervaller af på hinanden følgende tal. Tallene 3, 4, 5, 6 bliver for eksempel til parret `(3, 7)`.

Tal, der ikke er en del af et interval, bliver til et par med kun ét tal, så 2 bliver til `(2, 3)`. Metoden returnerer en liste af tupler: `List<(int Start, int Slut)>`.

Skriv derefter kode i `Main`, der udskriver resultatet. Par med kun ét tal skal vises som et enkelt tal. Kaldet

```csharp
var resultat = FindIntervaller(new List<int> { 2, 5, 4, 8, 12, 6, 7, 10, 13 });
```

skal give dette output:

```
[2,(4,9),10,(12,14)]
```

Bemærk, at det andet tal i et par ikke hører med til intervallet – ligesom i løkken `for (int i = start; i < slut; i++)`. Du kan antage, at intet tal forekommer mere end én gang i inputlisten.

### Øvelse 13 (vend ordbog)

Lad `d` være et _Dictionary_ af typen `Dictionary<string, List<string>>`, der har engelske ord som nøgler og en liste af finske ord som værdier. Ordbogen kan bruges til at finde de finske ord for et engelsk ord:

```csharp
d["move"]   // ["liikuttaa"]
d["hide"]   // ["piilottaa", "salata"]
```

Lav en metode `VendOrdbog`, der ud fra en engelsk-finsk ordbog givet som parameter laver en finsk-engelsk ordbog. Værdierne i den nye ordbog skal være lister af ord. 
Det skal virke sådan her:

```csharp
var d = new Dictionary<string, List<string>>
{
    ["move"] = new List<string> { "liikuttaa" },
    ["hide"] = new List<string> { "piilottaa', 'salata" },
    ["six"] = new List<string> { "kuusi" },
    ["fir"] = new List<string> { "kuusi" }
};

var omvendt = VendOrdbog(d);
foreach (var par in omvendt)
{
    Console.WriteLine($"{par.Key}: {string.Join(", ", par.Value)}");
}
```

Output:

```
liikuttaa: move
piilottaa: hide
salata: hide
kuusi: six, fir
```

Pas på med synonymer og homonymer!
## Strenghåndtering

### Øvelse 18 (akronymer)

Skriv en metode `Akronymer`, der tager en streng som parameter og returnerer en liste (`List<string>`) af akronymer. Et ord er et akronym, hvis det er mindst to tegn langt, indeholder mindst ét bogstav, og alle dets bogstaver er store.

Del teksten op i ord med `Split(' ')`. Før du undersøger, om et ord er et akronym, skal du fjerne tegnsætning i starten og slutningen af ordet med `Trim`-metoden, f.eks. `ord.Trim('.', ',', '(', ')')`. Metoderne `char.IsLetter` og `char.IsLower` kan også være nyttige.

Test metoden i `Main` med dette kald:

```csharp
var resultat = Akronymer(@"For the purposes of the EU General Data Protection Regulation (GDPR), the controller of your personal information is International Business Machines Corporation (IBM Corp.), 1 New Orchard Road, Armonk, New York, United States, unless indicated otherwise. Where IBM Corp. or a subsidiary it controls (not established in the European Economic Area (EEA)) is required to appoint a legal representative in the EEA, the representative for all such cases is IBM United Kingdom Limited, PO Box 41, North Harbour, Portsmouth, Hampshire, United Kingdom PO6 3AU.");
Console.WriteLine(string.Join(", ", resultat));
```

Det skal give dette output:

```
EU, GDPR, IBM, IBM, EEA, EEA, IBM, PO, PO6, 3AU
```

### Øvelse 19 (sumligning)

Skriv en metode `SumLigning`, der tager en liste af positive heltal (`List<int>`) som parameter og returnerer en streng med en ligning for summen af elementerne.

Eksempel: `SumLigning(new List<int> { 1, 5, 7 })` returnerer strengen `"1 + 5 + 7 = 13"`.

Mellemrummene skal være præcis som vist. For en tom liste skal metoden returnere strengen `"0 = 0"`. Metoden `string.Join` kan være nyttig.
