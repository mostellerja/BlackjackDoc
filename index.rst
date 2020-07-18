.. Blackjack documentation master file, created by
   sphinx-quickstart on Thu Jul 16 13:21:07 2020.
   You can adapt this file completely to your liking, but it should at least
   contain the root `toctree` directive.

===========================
**Console Blackjack in C#**
===========================
.. image:: /image/WelcomeBlackjack.PNG

.. image:: /image/BlackjackClip.jpg






.. toctree::
   :maxdepth: 2
   :caption: Contents:



Introduction
------------
Blackjack is a very popular card game 
where the player attempts to get a combination
of cards where their collective number values are less 
than or equal to 21.  If the player has a value over 21,
they automatically lose, or otherwise known as "busted".

Description
-----------
As a fan of the game Blackjack, I wanted to make a virtual
version for myself to play whenever I had the desire to. So I decided 
to make a version of Blackjack that operates within the terminal 
console of any computer. Console Blackjack was created in C#, a 
popular programming language that developers use when coding games.
Console Blackjack was coded within the Microsoft Visual Studio environment.
At the start of the game, the player is given two cards with numerical
values, which are generated randomly within each game. If the player decides to 
"hit", they are given another randomly-generated card value which is added to their
total. The total of the dealer is also randomly generated, meaning that the outcome 
of the game is never certain until it is finished. 

Here is a small section of code that shows the random nature of the cards:

.. image:: /image/cardGenCode.PNG

Installation
------------

Instructions:
#############

* **In order to play Console Blackjack, you need a terminal on your computer.**
* To obtain a copy of Console Blackjack, click `here <https://github.com/mostellerja/BlackjackDoc>`_.
* Click on the green button that says "Code" with a down arrow on it.
* Click on the button that says "Download ZIP".
* Open the "BlackjackDoc-master.zip" folder that was downloaded.
* Click the button that says "Extract all" to unzip the folder.
* Click "Extract" at the bottom of the window.
* Click on the "BlackjackDoc-master" folder.
* Click on "ProjectBlackjack.exe" to play Console Blackjack.


Gameplay
--------
Playing Console Blackjack is very simple, follows the same
rules as Blackjack, which are as follows:

* You are dealt two cards, both containing number values.
* Cards 2 through 9 are simply their number value.
* An Ace is equal to 11.
* A Jack, Queen, or King is equal to 10.
* You can type "hit" if you feel if your combined value is too low, or type "stay" if you are confident with your total.
* If you hit and your combined total exceeds 21, then you automatically lose.
* If your total is less than the dealer's total, but he has a higher value less than or equal to 21, you lose.
* If the dealer's total exceeds 21, you lose.
* If your total is automatically 21 from the beginning, you win Blackjack!

Here is an demonstration of Console Blackjack:

Once you open Console Blackjack, you while be presented with a screen
similar to this, but only your card number values may be different:

.. image:: /image/StartScreen.PNG

Now you are given a choice to "hit" to gain another card, or to "stay" to keep your total.
In this scenario, I chose to "stay", keeping my total of 18:

.. image:: /image/stayType.PNG

After I chose to hit, the dealer's hand is revealed, along with the outcome of the game:

.. image:: /image/stayLoss.PNG

As a result of a loss, I am given a choice to play again by either typing "y" for yes, or "n" for no.

.. image:: /image/yNewGame.PNG

After typing "y" and pressing enter, I must press the enter key once more to start a new game.

.. image:: /image/newGameAfterEnter.PNG

Alternatively, I can select to quit after a game by typing "n", followed by pressing the enter key.

.. image:: /image/enterToQuit.PNG

After pressing the enter key once more after the prompt, the game closes.

Bugs and Issues
---------------
* Some grammatical issues lie within the message prompts, such as where "dealed" should be "dealt".
* Although the "Ace" card can have the value of 1 or 11, it currently only has the value of 11.


Contribute
----------
If you wish to obtain the source code for Console Blackjack, click `here <https://github.com/mostellerja/BlackjackDoc>`_.


FAQ
---

1. Can I use this code and modify it?
#####################################
* Console Blackjack and all of its contents may be modified and used by the user.

2. When was the last significant update?
########################################
* Console Blackjack was last updated on May 9th, 2016.

3. How many games of Console Blackjack can I play?
##################################################
* Console Blackjack can be played again as long as the user types "y" when prompted to start another game.

Support
-------
If you encounter any bugs or issues not listed above, or would like to give
feedback about Console Blackjack please feel free to email me at the following 
address:	aaron42499@gmail.com

License
-------
Console Blackjack and all of its contents is protected under `Boost Software License v1.0 <https://www.boost.org/LICENSE_1_0.txt>`_.
