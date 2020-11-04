# Initiation à la programation <!-- omit in toc -->

- [1. Objectif du cours](#1-objectif-du-cours)
- [2. Expressions](#2-expressions)
  - [2.1. Expressions numériques](#21-expressions-numériques)
    - [2.1.1. les entiers](#211-les-entiers)
    - [2.1.2. les flottants](#212-les-flottants)
  - [2.2. Expressions booléennes](#22-expressions-booléennes)
    - [2.2.1. L'operateur ou](#221-loperateur-ou)
    - [2.2.2. L'operateur et](#222-loperateur-et)
    - [2.2.3. L'operateur non](#223-loperateur-non)
  - [2.3. Caractères et chaînes de caractères](#23-caractères-et-chaînes-de-caractères)
    - [2.3.1. Le type `char`](#231-le-type-char)
    - [2.3.2. Le type `string`](#232-le-type-string)
- [3. Instructions](#3-instructions)
  - [3.1. Instructions d'impression](#31-instructions-dimpression)
  - [3.2. Instruction du jeu de carte sous Unity](#32-instruction-du-jeu-de-carte-sous-unity)
    - [3.2.1. Initialisation des deck](#321-initialisation-des-deck)
    - [3.2.2. Déplacer des cartes](#322-déplacer-des-cartes)
- [4. Annexe sur les `Boolean`](#4-annexe-sur-les-boolean)
  - [4.1. Propriétés des opérateurs](#41-propriétés-des-opérateurs)
  - [4.2. Remarque sur les opérateurs && et ||](#42-remarque-sur-les-opérateurs--et-)

________________________________________________________________________________
## 1. Objectif du cours

Il s'agit de poser les notions de base en programmation impérative :

- expressions et instructions
- constantes, variables et affectation. Variables locales
- types de données simples : nombres entiers ou non entiers, booléens, caractères et chaînes de caractères
- expressions et instructions conditionnelles (instruction "if")
- répétition conditionnelle d'instructions (boucle "While")
- répétition non conditionnelle d'instructions (boucle "for")
- Paramètres formels, paramètres effectifs

Pour ce cours, nous utiliserons le langage `CSharp` (noté `C#`) dans le contexte du framework de Jeu Vidéo `Unity` 

________________________________________________________________


## 2. Expressions

Une expression est une manière de représenter un calcul.
Par exemple, l'aire d'un disque de rayon `r` est donnée par l'expression suivante:

`πr^2`

Cette expression est composée de plusieurs sous-expressions. Certaines sous-expressions ne peuvent plus être décomposées, elles sont atomiques. Il s'agit soit de constantes, soit de variables, soit de fonctions ou d'opérateurs.

```
        *
      /  \
    π     ^
        /  \
      r     2

```

Dans les formules les grandeurs possèdent ce que les physiciens appellent des dimensions, en informatique on parle plutôt de types.

Lorsqu'on écrit de manière traditionnelle une expression, un certain nombre de conventions d'écriture nous permet d'omettre certains signes d'opérations. Ici, par exemple, les signes de multiplications sont implicites. Lorsqu'on souhaite traduire cette expression de manière informatique, il faudra savoir que des règles strictes devront être appliquées, l'ensemble de ces règles forme la syntaxe du langage, et il faudra absolument les respecter pour espérer obtenir un résultat.

### 2.1. Expressions numériques

La syntaxe des expressions numériques est très proche de la notation mathématique usuelle.
Prenons pour exemple l'instruction suavante:

```
(4*(-3+5))/2;
```

- Tout d'abord l'expression `(4 * (-3 + 5)) / 2`. Elle est très proche de la notation mathématique usuelle, les nombres sont notés comme d'habitude, l'addition et la division aussi, la multiplication est notée \*, et on utilise des parenthèses pour marquer ici la priorité de certaines opérations sur d'autres.
- L'expression est terminée par un point virgule `;`. C'est la manière de dire à l'interpréteur que l'expression est terminé et qu'il peut procéder à son évaluation.

#### 2.1.1. les entiers

Lors de l'évaluation de l'expression par l'interpréteur, ce dernier va derterminé le type de retour en fonction de l'instruction
si vous n'utiliser que des entiers et que vous n'utilsez pas l'opérateur de division, l'interpréteur determinera que vous travailler avec les entiers.

Par exemple l'expression suavante:
```
(4*(-3+5))
```
 renverra un entier (`int` pour _integer_)

#### 2.1.2. les flottants

Bien entendu, on peut calculer des nombres non entiers que nous nommerons nombres flottants (_float_). Ces nombres sont tous marqués d'un séparateur décimal, le point, qu'ils soient ou non dotés de chiffres après la virgule.

les expressions suivantes sont évalué par l'interpreteur comme des expressions flottantes:

```
4.3333f
4.0f
3+4.3333f
3+4f
7/3
...

```

### 2.2. Expressions booléennes

En programmation, les expressions booléennes sont nécessaires pour effectuer des calculs ou exécuter des instructions dépendant de la réalisation ou non de certaines conditions.
Les booléens forment un ensemble à deux valeurs seulement, désignés en C# par `true` (vrai) et `false` (faux). Le type des booléens est désigné par bool.

Les expressions booléennes sont les expressions qui ont pour valeur l'un des deux booléens. Elles apparaissent naturellement dans les comparaisons.

```
true
false
```

Les opérateurs logiques usuels sont && (et), || (ou) et !(négation). Ainsi que les parenthèse pour ordonancé les operations.

```
true || false
false && true
!true
(true && false) || false
false && (true || ! false)
```

#### 2.2.1. L'operateur ou

table de vérité

| a     | b     | a ou b |
| ----- | ----- | ------ |
| true  | true  | true   |
| false | true  | true   |
| true  | false | true   |
| false | false | false  |

#### 2.2.2. L'operateur et

table de vérité

| a     | b     | a et b |
| ----- | ----- | ------ |
| true  | true  | true   |
| false | true  | false  |
| true  | false | false  |
| false | false | false  |

#### 2.2.3. L'operateur non

table de vérité

| a     | !a    |
| ----- | ----- |
| true  | false |
| false | true  |



### 2.3. Caractères et chaînes de caractères

#### 2.3.1. Le type `char`

Le mot clé `char` représente un type qui représente un caractère Unicode UTF-16.

Une expression littérale de type `char` est obtenue en plaçant le caractère voulu entre apostrophes.
```
'a'
'b'
','
...
```

#### 2.3.2. Le type `string`

Représente le texte en tant que séquence d’unités de code UTF-16. (`char`)
Une chaîne est une collection séquentielle de caractères utilisée pour représenter du texte.

Une expression littérale de type `string` est obtenue en plaçant le caractère voulu entre guillemets.

les exemples suivant montrent des instanciation de `string`

```
"ceci est une string !!!"
"cela aussi ;)"
```


## 3. Instructions

En C#, une instruction est une expression dont la valeur est de type `void`. Ce type ne contient pas de valuer. Par conséquent, cela signifie que toute instruction ne retourne pas de valeur et ce même avant que l'expression ne soit évaluée, et donc que ce qui importe n'est pas tant la valeur de retour de l'instruction, que l'effet de bord qu'elle produit. Et d'ailleurs, plutôt que de parler d'évaluation de l'expression, on dit plutôt exécution de l'instruction.

Les effets de bord produits par l'exécution d'une instruction peuvent être de plusieurs natures :

- modification de la valeur de l'environnement courant de travail, par exemple en modifiant la valeur d'une variable.
- communication du programme avec le monde extérieur, par exemple, par lecture ou écriture d'une valeur.

### 3.1. Instructions d'impression

Plus intéressante est l' instruction pour imprimer ou écrire des valeurs spécifique à Unity. 

``` 
Debug.Log("Hello world!");
```

Il faut bien comprendre que la réponse de l'interprète à l'exécution de cette instruction ne retourne pas à proprement parler de valeur. Elle se contentre d'imprimer un log dans la console de Unity.


### 3.2. Instruction du jeu de carte sous Unity

#### 3.2.1. Initialisation des deck

Quand vous lancé le jeu, Unity montre 4 tas de cartes.
Pour initialisé ces tas appelé `deck` il faudra utiliser l'instruction du GameManager:

```
gm.InitDeck(deck1,"TCP");
```

Cette instruction prend en paramètre le deck à initialisé ainsi qu'une chaine de charactère decrivant la manière de l'initialiser.


La chaîne de description, lue de gauche à droite, indique les cartes d'un tas du bas vers le haut avec les conventions suivantes :

- Les lettres T, K, C, P représentent respectivement : ♣, ♢, ♡ et ♠
- Si A et B sont des chaînes de description, la chaîne AB est aussi une chaîne de description qui représente les cartes de A surmontées de celles de B
- Si A et B sont des chaînes de description, la chaîne A + B est aussi une chaîne de description qui représente un choix entre les cartes de A ou celles de B
- Si A est une chaîne de description, [A] représente la répétition des cartes de A un nombre quelconque (défini de manière aléatoire) de fois (y compris zéro)
- Les parenthèses sont autorisées pour éviter les ambiguïtés


__Exemples:__

1. L'instruction `gm.InitDeck(deck1,"");` déclare le tas numéro 1 vide.
2. L'instruction `gm.InitDeck(deck1,"TCK");` décrit le tas numéro 2 contenant de bas en haut un ♣, un ♡ et un ♢.
3. L'instruction `gm.InitDeck(deck1,"T+P");` décrit le tas numéro 3 contenant une carte qui est soit un ♣ soit un ♠.
4. L'instruction `gm.InitDeck(deck1,"[T+P]");` décrit le tas numéro 4 contenant un nombre quelconque, non déterminé, de cartes de couleur ♣ ou ♠.
5. L'instruction `gm.InitDeck(deck1,"T+[P]CC");` décrit le tas numéro 1 contenant soit une seule carte de couleur ♣, soit un nombre quelconque de ♠ surmontés de deux ♡.
6. L'instruction `gm.InitDeck(deck1,"(T+[P])CC");` décrit le tas numéro 1 contenant soit trois cartes ♣ surmontées de deux ♥, soit un nombre quelconque de ♠ surmontés de deux ♡. À noter qu'une autre façon de décrire la même initialisation est d'utiliser la chaîne "TCC + [P]CC".

#### 3.2.2. Déplacer des cartes

La seule action permettant de modifier l'état des tas est le déplacement de la carte située au sommet d'un tas vers le sommet d'un autre tas. Cette action est donnée par un appel à la procédure `MoveTopCard`.

```
gm.MoveTopCard(deck1,deck2);
```

où `deck1` est le deck duquel on prend une carte, et `deck2` est celui sur lequel on la pose.

> __Condition d'Utilisation__ : Il n'est pas permis de déplacer une carte située sur un tas vide. Toute tentative d'action `MoveTopCard(deck1,deck2)` déclenche une exception si deck1 est vide.


______________________________________________

## 4. Annexe sur les `Boolean` 

### 4.1. Propriétés des opérateurs

a, b et c sont trois expressions booléennes.

| proprités                              | expression                           |
| -------------------------------------- | ------------------------------------ |
| Double négation                        | !(!a) = a                            |
| Élément neutre du ou                   | a ou False = a                       |
| Élément neutre du et                   | a et True = a                        |
| Élément absorbant du ou                | a ou True = True                     |
| Élément absorbant du et                | a et False = False                   |
| Idempotence du ou                      | a ou a = a                           |
| Idempotence du et                      | a et a = a                           |
| Tautologie                             | a ou !a = True                       |
| Contradiction                          | a et !a = False                      |
| Commutativité du ou                    | a ou b = b ou a                      |
| Commutativité du et                    | a et b = b et a                      |
| Associativité du ou                    | (a ou b) ou c = a ou (b ou c)        |
| Associativité du et                    | (a et b) et c = a et (b et c)        |
| Distributivité du et par rapport au ou | a et (b ou c) = (a et b) ou (a et c) |
| Distributivité du ou par rapport au et | a ou (b et c) = (a ou b) et (a ou c) |
| Loi de Morgan (1)                      | !(a ou b) = !a et !b                 |
| Loi de Morgan (2)                      | !(a et b) = !a ou !b                 |

### 4.2. Remarque sur les opérateurs && et ||

En logique booléenne, les opérateurs et et ou sont commutatifs

`a et b = b et a`

`a ou b = b ou a`

En C#, ces opérateurs ne sont pas commutatifs : les arguments sont évalués séquentiellement de gauche à droite.

Les expressions `DeckIsEmpty(deck1) && topCardColor(deck1)` et `topCardColor(deck1) && DeckIsEmpty(deck1)` ne sont pas équivalentes :

l'évaluation de la première expression ne déclenche jamais d'exception, car si le tas 1 est vide, `topCardColor(deck1)` n'est pas évalué, puisque la valeur de l'expression complète est alors déterminée ;

`!DeckIsEmpty(deck1) && topCardColor(deck1);`

en revanche l'évaluation de la seconde expression déclenche une exception si le tas 1 est vide.

`topCardColor(deck1) && !DeckIsEmpty(deck1);`