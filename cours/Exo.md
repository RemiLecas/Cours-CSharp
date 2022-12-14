### Questions RPI

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

// Décrire le fonctionnement des enums en C#

/* Les enums permettent de définir un ensemble de constante comme ici avec les jours de la semaine.  */
```


#### Les tableaux multidimensionnels

```C#
	int [,] Tableau = new int[1, 2];
	int [,,] Tableau = new int[1, 2, 3];


	int[][] Tableau = new int[3][];
	Tableau[0] = new int[] {45, 2};
	Tableau[1] = new int[] {34, 34, 4, 67};

	//Expliquez la différence entre ces syntaxes
	
	/* Ce sont l'instanciation et le typage des tableaux qui sont différentes */
	
	//Tentez de parcourir des tableaux multidimensionnels avec des boucles for
	/* 
            for(int i = 0; i < Tableau.Length - 1; i++){
                for(int j = 0; j < Tableau[i].Length; j++){
                    Console.WriteLine(Tableau[i][j]);
                }
            }
	} */
```

#### Les Types

Exercice : Que signifie le terme "assembly" 

Citez un exemple réel d'un usage pertinent du mot clé "private".


### Les API

Qu'es qu'un ORM ?
- Un ORM est une interface qui simule une base de données

Il faut faire une API Web répondant à une problématique avec quelques objets lieer entre eux., avoir une base de données relationnel : MYSQL, SQL Server.

Avoir un dossier qui contient les controllers, utiliser Entity FrameWork, un ORM.

A partir de classe Entity FrameWork il faut créer automatiquement nos BDD + mettre à jour automatiquement la BDD + accèder automatiqument à la BDD

Faire un Readme claire et explicite.

Swagger permet d'interargir automatiquement avec l'API (Testeur d'API) = POSTMAN


Update (Patch), Deleate, Get = Méthode à utiliser pour le projet de fin de semaine