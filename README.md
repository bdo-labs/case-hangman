# case-hangman
Repo brukt for hangman caset til BDO



Spillet starter
- trekke random fra en liten samling ord
- spiller får oppgitt lengde på løsningsord

Spillsekvens starter
- spiller gjetter en og en bokstav
	- feedback
		- status: { won, lost, inProgress }
		- guessedResult:
			- gal gjetning: []
			- riktige bokstaver: [1, 4]

Spillet er ferdig
- løsningsord er gjettet
- brukt opp antall gjetningsforsøk
