# Initiation à la programation

## Objectif du cours

Il s'agit de poser les notions de base en programmation impérative :

- expressions et instructions
- constantes, variables et affectation. Variables locales
- types de données simples : nombres entiers ou non entiers, booléens, caractères et chaînes de caractères
- expressions et instructions conditionnelles (instruction "if")
- répétition conditionnelle d'instructions (boucle "While")
- répétition non conditionnelle d'instructions (boucle "for")
- Paramètres formels, paramètres effectifs

Pour ce cours, nous utiliserons le langage Javascript

## Expressions et instructions

### Expressions

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

### Expressions numériques

La syntaxe des expressions numériques est très proche de la notation mathématique usuelle.
Prenons pour exemple l'instruction suavante:

```
(4*(-3+5))/2;
```

- Tout d'abord l'expression `(4 * (-3 + 5)) / 2`. Elle est très proche de la notation mathématique usuelle, les nombres sont notés comme d'habitude, l'addition et la division aussi, la multiplication est notée \*, et on utilise des parenthèses pour marquer ici la priorité de certaines opérations sur d'autres.
- L'expression est terminée par un point virgule `;`. C'est la manière de dire à l'interpréteur que l'expression est terminé et qu'il peut procéder à son évaluation.

#### les entiers

Lors de l'évaluation de l'expression par l'interpréteur, ce dernier va derterminé le type de retour en fonction de l'instruction
si vous n'utiliser que des entiers et que vous n'utilsez pas l'opérateur de division, l'interpréteur determinera que vous travailler avec les entiers.

Par exemple l'expression suavante `(4*(-3+5));` renverra un entier (_int_ pour _integer_)

#### les flottants

Bien entendu, on peut calculer des nombres non entiers que nous nommerons nombres flottants (_float_). Ces nombres sont tous marqués d'un séparateur décimal, le point, qu'ils soient ou non dotés de chiffres après la virgule.

les expressions suivantes sont évalué par l'interpreteur comme des expressions flottantes:

```
4.3333;
4.;
3+4.3333;
3+4.;
7/3;
...

```

### Expressions booléennes

En programmation, les expressions booléennes sont nécessaires pour effectuer des calculs ou exécuter des instructions dépendant de la réalisation ou non de certaines conditions.
Les booléens forment un ensemble à deux valeurs seulement, désignés en Javascript par true (vrai) et false (faux). Le type des booléens est désigné par bool.

Les expressions booléennes sont les expressions qui ont pour valeur l'un des deux booléens. Elles apparaissent naturellement dans les comparaisons.

```
true;
false;
```

Les opérateurs logiques usuels sont && (et), || (ou) et !(négation). Ainsi que les parenthèse pour ordonancé les operations.

```
true || false;
false && true;
!true;
(true && false) || false;
false && (true || ! false);
```

#### L'operateur ou

table de vérité

| a     | b     | a ou b |
| ----- | ----- | ------ |
| true  | true  | true   |
| false | true  | true   |
| true  | false | true   |
| false | false | false  |

#### L'operateur et

table de vérité

| a     | b     | a et b |
| ----- | ----- | ------ |
| true  | true  | true   |
| false | true  | false  |
| true  | false | false  |
| false | false | false  |

#### L'operateur non

table de vérité

| a     | !a    |
| ----- | ----- |
| true  | false |
| false | true  |

#### Propriétés des opérateurs

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

#### Remarque sur les opérateurs && et ||

En logique booléenne, les opérateurs et et ou sont commutatifs

`a et b = b et a`

`a ou b = b ou a`

En Javascript, ces opérateurs ne sont pas commutatifs : les arguments sont évalués séquentiellement de gauche à droite.

Les expressions `tasVide(tas1) && couleurSommet(tas1)` et `couleurSommet(tas1) && tasVide(tas1)` ne sont pas équivalentes :

l'évaluation de la première expression ne déclenche jamais d'exception, car si le tas 1 est vide, `couleurSommet(tas1)` n'est pas évalué, puisque la valeur de l'expression complète est alors déterminée ;

`!tas_vide(tas1) && couleur_sommet(tas1);`

en revanche l'évaluation de la seconde expression déclenche une exception si le tas 1 est vide.

`sommet_trefle(1) && tas_non_vide(1);`

### Caractères et chaînes de caractères

Les chaînes de caractères sont des suites finies de caractères placés les uns à la suite des autres. Elles peuvent ne contenir aucun caractère : chaîne vide ou _n_ charactères.

En JavaScript, vous pouvez envelopper vos chaînes entre des guillemets simples ou doubles. Les deux expressions suivantes sont correctes :

```
'Guillemet simple.';
"Guillemets doubles.";
```

Il y a une toute petite différence entre les deux, et celle que vous retenez relève de la préférence personnelle. Prenez-en une, et tenez‑vous y toutefois : du code avec des mises entre guillemets diversifiées peut amener des confusions, en particulier si vous utilisez les deux sortes dans la même chaîne ! Ce qui suit renvoie une erreur :

```
'Quoi sur Terre ?"; => invalide
```

L'interpréteur pensera que la chaîne n'a pas été fermée, car le type de guillemet autre ne servant pas à délimiter les chaînes peut y être employé. Par exemple, ces deux assertions sont valables :

```
'Mangeriez‑vous un "souper de poisson"?';
"J'ai le blues.";
```

Bien entendu, vous ne pouvez pas inclure dans la chaîne le même type de guillemet que celui qui est utilisé pour la délimiter. Ce qui suit conduit à une erreur, car l'explorateur ne peut pas déterminer là où se termine la chaîne :

```
''Je n'ai pas eu droit à prendre place...'; => invalide
```
