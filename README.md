# Introduction

Ce petit projet regroupe une succession de quêtes, chacune sur une thématique particulière. Ce projet sera enrichi au fur et à mesure afin de pouvoir aider les apprenants dans leur découverte du C# et de l'écosystème associé.

Les solutions des différents exercices ne sont pas directement disponibles mais des tests unitaires permettent de valider les solutions proposées par les apprenants.

# Prérequis

## Notions
Pour aborder ce parcours, il est conseillé d'avoir déjà eu une première expérience avec la programmation, quel que soit le langage.

## Outillage
Pour pouvoir profiter pleinement de ce parcours et notamment des tests unitaires, je vous recommande une des configurations suivantes :
- Visual Studio Community (disponible sous Windows et Mac)
- Visual Studio Code + Extension C# *ms-dotnettools.csharp* (disponible sous Windows, Mac et Linux)
- JetBrains Rider (disponible sous Windows, Mac, Linux)

Dans ce README, je décrirais l'usage avec *Visual Studio Community* et *Visual Studio Code*, mais si vous utilisez Rider, je pense que vous saurez vous en sortir ! (En attendant que quelqu'un rajoute les instructions pour cet IDE).

# Liste des thématiques
- Quête 1 : Types primitifs
- Quête 2 : Control flow (conditions, boucles...)
- Quête 3 : Chaînes de caractères
- Quête 4 : DateTime
- Quête 5 : Les tableaux

### Idées de nouvelles quêtes à créer :
- Les collections
- Les exceptions
- Les énumérations
- Les expressions régulières
- Les types génériques
- LINQ

# Comment résoudre un exercice ?
Pour résoudre chaque exercice, il faut éditer le corps de fonction associée, puis lancer les tests unitaires associés pour valider la solution proposée.

# Comment utiliser les tests unitaires ?
## Dans Visual Studio Community
Tous les tests existants sont visibles dans la fenêtres intitulée *Explorateur de tests*. Celle-ci est accessible via le menu *Affichage* > *Explorateur de tests*. Ensuite il suffit de sélectionner le (ou les) test(s) à lancer, de faire un clic droit et de choisir *Exécuter*

## Dans Visual Studio Code
Dans VS Code, il n'y a pas de vue pour visualiser les tests et les lancer en "clic clic". C'est par contre très simple de les lancer en ligne de commande dans le terminal au bas de l'écran avec la commande 
```
dotnet test
```
Cette commande lancera l'intégralité des tests.

*Astuce* : Pour exécuter seulement certains tests, il est possible de spécifier ceux à exécuter avec l'argument *--filter* suivi du nom de la classe (ou de la méthode) à lancer. 

Par exemple, pour lancer les tests relatifs à l'exercice *01_HelloWorld.cs*, on pourra lancer la commande 
```
dotnet test --filter 01_HelloWorld
```


# Comment contribuer à ce projet ?
Il y a de multiples manières d'aider à ce projet. Vous pouvez notamment :
- Traduire les énoncés dans différentes langues
- Rajouter de nouveaux exercices dans des quêtes existantes
- Créer de nouvelles quêtes
- Ajouter davantage de tests unitaires
- Corriger/compléter les énoncés imprécis
- Et surement bien d'autres choses encore :)

# Les contributeurs derrière ce projet
- [Alexandre Dubois](https://www.linkedin.com/in/alexandredubois) 
- Vous ? ;)