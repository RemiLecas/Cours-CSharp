GCP = Google Cloud Platform

C# est un langage compilé 

Le framework .NET est l'élément central des applications.

Il est constitué de deux éléments: 
- Le CLR
- Des bibliothèques de classes

Le compilateur va intrépreter tout le langage (écrit) dans un code intermédiaire pour pouvoir le lire.

Une fois compilé l'application se resume a un fichier éxécutable au sein de l'environnement cible.

DLL = bibliothèque partagée

### Les bibliothèques de classe

Le framework .NET est composé de plusieurs bibliothèques de classes, classes en espaces de noms, eux memes classe de maniere  hierarchique a partir d'un espace de nom racine appelé: 
`````C#
System // Espace de nom racine. Il contient les types de bases du framework .NET
System.Collections //Tous les types permettant de gerer les listes et les tableaux
``````

.NET est composé de deux types différents: les types valeurs et les types reference.

### Les types valeurs :

```C#
int
bool
char
struct
enum
string

int test = 4; // Instruction qui déclare une variable et qui affecte une 
			  // valeur
int test2; // Une declaration de type valeur sans affectation entraine la levee d'une
		   // exception 
test2 = 4; // Affectation

bool b1 = true; // 

bool b2 = b1;  // on affecte la valeur b1 sans aucun autre lien

b1 = false;
```

### Les types references :

Les donnees des types reference sont stockes a un emplacement memoire et un pointeur vers ces donnees est stocke dans la variable.

Les classes et les interfaces sont des types reference.
Un type reference doit etre instancie avec le mot cle 'new'

```C#
System.Collections // Espace de nom

ArrayList tab1 = new ArrayList(); // Permet de déclaré un type référence

ArrayList tab1 = new ArrayList(1);

ArrayList tab2 = new(); // on peut omettre le type lorsqu'il n'y a pas de parametres

```

Pour illustrer le fonctionnement des types reference, prenons un exemple : 
```C#
class Test{
	public bool: boolean;
}

Test C1 = new Test();

C1.boolean = true;

Test C2 = C1;

C1.boolean = false;

```

### Les identifiants et les mot-cles

```C#

string monIdentifiant;

string MonIdentifiant;


```

Les opérateurs d'assignation : 

```C#
int i = 4;

i += 2; // 6
i -= 2; // 2
i *= 2; // 8
i /= 2; // 2
i %= 2; // 0

int x = 4;
x is int // retourne un boolean

o is DateTime d // renvoie true si o est type DateTime
// La variable o est automatiquement convertie dans le type teste et place dans la
// nouvelle variable d et utilisable de manière classique

var test = new Test(); //inference de type
const int i = 0;
```

Les instructions de controle : 
```C#
if(x > 4){ // if évalue l'expression 
	//expression
}else{
	//expression2
}
```

```C#

string myObject = obj?.foo?.bar;

// équivalent à

if(obj != null && obj.foo != null){
	myObject = obj?.foo?.bar;
}

```

### Les espaces de noms

#### Déclaration d'un espace de nom
```C#
	namespace EspaceDeNom{
		class MaClasse()
	}
```

#### Les conversions

```C#
int i = 45; // entier signé sur 32 bits

long k = i; // entier signé sur 64 bits
```

#### Les Enums

```C#
enum LesJoursDeLaSemaine{
	Lundi,
	Mardi,
	Mercredi,
	Jeudi,
	Vendredi,
	Samedi,
	Dimanche
}

LesJoursDeLaSemaine Weekend = LesJoursDeLaSemaine.Samedi | LesJoursDeLaSemaine.Dimanche;
```


#### Les Tableaux

```C#
	int[] Tableau; // declaration
	Tab = new int[10]; // Initialisation

	int[] Tableau = new int[] {34, 45, 1, 34, 43 }; //
```

#### Les tableaux multidimensionnels

```C#
	int [,] Tableau = new int[1, 2];
	int [,,] Tableau = new int[1, 2, 3];


	int[][] Tableau = new int[3][];
	Tableau[0] = new int[] {45, 2};
	Tableau[1] = new int[] {34, 34, 4, 67};
```

#### Les Types

Les classes en C# representant la grande majorite des types reference.

```C#
class maSuperClasse{

}
```

On peut y ajouter des éléments :
- Des membres (méthodes, propriétés) places entre accolades
- Des attributs et des modificateurs de classe (niveau d'accès) placés avant le mot-clé 'class'
- Des héritages et implementations d'interfaces placés après le nom de la classe

#### Les niveaux d'accès (portée)
- public : autorise l'accès pour les types de l'assemblage (assembly) et hors de l'assembly.
- private : autorise uniquement l'accès pour les autres membres du type (de la classe par exemple).
- protected : autorise l'accès uniquement pour les autres membres du type et pour mes types héritant de celui-ci (dans l'assembly et en dehors de l'assembly)
- internal : autorise l'accès pour les types d'assembly.
- protected internal : autorise l'accès uniquement pour les autres membres du type et pour mes types héritant de celui-ci (dans l'assembly uniquement)

**Si aucune portée n'est precisé sur un membre, il est considéré comme private. Une classe sans modificateur sera quand a elle consideree comme public.**

Les struct en C# ressemblent aux classes mais sont de type valeur, elles ne supportent pas l'héritage.

```C#
	struct Coordinates{
		double Lng;
		double Lat;
	}

	Coordinates myGeoPoint = new Coordinates();
```

Un peu de vocabulaire sur les classes
```C#
public class SuperClass{
	protected string filepath = "/dev/"; // champ, une variable qui peut être un type 
										// valeur ou un type reference
	public int MyProperty { get; set; }; // propriété
	
	public void WriteFile(){
		// ....
	}
	
	public void WriteFile(string filePath){
		// .... exemple de surcharge
	}
}

SuperClass obj = new SuperClass();
obj.MyProperty

```

##### L'héritage

Toutes les classes du framework .NET dérivent de la classe System.Object.

L'heritage correspond a deux fonctionnalités

Lors de l'heritage de classe un type dérive d'un type de base en prenant tous ses membres accessibles. Cette fonctionnalité est utile lorsque plusieurs types partagent les mêmes fonctionnalités.

```C#
public partial class ChildClass: MotherClass
{

}
```

Si aucune classe de base n'est spécifiée, le compilateur considère System.Object comme la classe mère.

```C#
public class ChildClass: System.Object
{

}
/// est equivalent à
public class ChildClass 
{

}
```
Les membres accessibles depuis la clase dérivée sont ceux qui ont un niveau d'acces public, protected ou internal (mais vous le saviez déjà...). Cela s'applique aux méthodes et aux propriétés:

###### [](https://github.com/bendahmanem/RPI-2022-2023-CSHARP/blob/main/C%23.md#les-membres-virtuels)Les membres virtuels

en déclarant un membre avec le mot-cle virtual, vous autorisez le membre à être surchargé par les classses dérivées. Cela s'applique aux méthodes et aux propriétés. La méthode surchargée doit être explicitement déclarée en utilisant le mot-clé override.

La signature de la methode dans la classe fille doit etre identique à la signature de la méthode dans la classe mère.


### Les API

Une API est une interface connecté à une base de données, contient la logique d'une application.

Une API sert à standardiser les échanges avec le WEB en format JSON ou XML.

Code http commencant par 2 est en général bon signe

