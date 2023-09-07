#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <LiquidCrystal.h>

#define PIN_RS 2
#define PIN_E 3

#define SUBIR_LETRA  1
#define PROBAR_LETRA  2
#define BAJAR_LETRA  3
#define NO_BOTON 0

LiquidCrystal lcd(PIN_RS,PIN_E,4,5,6,7);

void setup()
{
    Serial.begin(9600);
    lcd.begin(16,2);
}

void initDisplayWord();
void changeLetter(int opNum);
void initGuess();
void testLetter();
void removeLife();
void checkWon();
void findLetters();
int includeGuesses();
void guessesPush();
void borrarError();
void initGuesses();

char alphabet[] = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
char animals[12][30] = {{"AGUILA"},{"FOCA"},{"HIENA"},{"TIGRE"},{"RATON"},{"PUMA"},{"GATO"},{"LEON"},{"CASTOR"},{"PANDA"},
{"SAPO"},{"PERRO"}};
int alphabetIndex = 0;
int lives = 3; 
char wordToGuess[25]; 
char guesses[25];               
char currentLetter = 'A';
int finish = 1; 
int alphabetLength = 25; 
int lettersGuessed = 0; 
char displayWord[25] = {"JUGAMOS?"};
int botonAntes = NO_BOTON;
unsigned long millisAntes = 0;
int flagResultado = 1;
int flagPerdiste = 0;
int flagError = 0;
char auxPerdiste[25]= "LOSE";
char auxGanaste[25]= "WIN";
char auxError[6];
int flagBloquearJuego = 1;

void loop()
{
	  unsigned long millisActual = millis();
  	int valorA0 = analogRead(A0);
  	int botonAhora = leerBoton();
  	if(flagResultado == 0){
    initGuesses();
    lcd.clear();
    lcd.setCursor(6,0);
    lcd.print(displayWord);
      if(flagPerdiste){
      lcd.setCursor(6,1);
      lcd.print(auxPerdiste);
      }
      else{
      lcd.setCursor(6,1);
      lcd.print(auxGanaste);
      }
   	delay(500);
    lcd.clear();   
    flagResultado = 1;
  }
  	lcd.setCursor(4,1);
    lcd.print(displayWord);
  	
  	if(millisActual - millisAntes >=1000){
       showLives(lives);
       lcd.setCursor(8,0);
       lcd.print(currentLetter);
       lcd.setCursor(0,0);
       lcd.print(guesses);
       if(finish)
       initGuess();
      flagBloquearJuego = 0;
     
 }
    if(flagError){
       lcd.setCursor(0,1);
       lcd.print(auxError);
      }
    else{
  	borrarError(); 
    }
     
   if(botonAhora != NO_BOTON && botonAhora != botonAntes && !flagBloquearJuego){
    
     switch(botonAhora){
      case SUBIR_LETRA:
      changeLetter(1);
      break;
      case PROBAR_LETRA:
      testLetter();
      break;
      case BAJAR_LETRA:
      changeLetter(-1);
      break;
    }
  }
  botonAntes = botonAhora;
}

void initGuess()
{
    currentLetter = 'A';
    alphabetIndex = 0;
    lives = 3;
    finish = 0;
    lettersGuessed = 0;
	  int numRandom = random(0,13);
    strcpy(wordToGuess,animals[numRandom]);
    initGuesses();
    initDisplayWord();
}

void initDisplayWord()
{
    for(int i = 0; i < strlen(displayWord); i++)
    {
        displayWord[i] = ' ';
    }
    for (int i = 0; i < strlen(wordToGuess); i++)
    {
        displayWord[i] = '_';
    }
}

void testLetter()
{
    if (finish)
    {
        initGuess();
    }
    else
    {
        if (!includeGuesses())
        {
            findLetters();
            flagError = 0;
        }
        else // si la ingrese pide otra letra a ingresar.
        {
            strcpy(auxError,"OTRA");
            flagError = 1;
        }
    }
}

void changeLetter(int opNum)
{
    if (finish)
    {
        initGuess();
    }
    else 
    {
        int aux = alphabetIndex + opNum;
        if (aux > alphabetLength)
        {
            alphabetIndex = 0;
        }
        else if (aux >= 0)
        {
            alphabetIndex = aux;
        }
        else
        {
            alphabetIndex = alphabetLength; 
        }
        currentLetter = alphabet[alphabetIndex];
    }
}

int includeGuesses()
{
    int todoOk = 0;
    if(guesses != NULL)
    {
        for(int i = 0; i < strlen(guesses); i++)
        {
            if(guesses[i] == currentLetter)
            {
                todoOk = 1;
                break;
            }
        }
    }
    return todoOk;
}

void findLetters()
{
    int guessedRight = 0;
    for (int i = 0; i < strlen(wordToGuess); i++)
    {
        if (wordToGuess[i] == currentLetter)
        {
            displayWord[i] = currentLetter;
            lettersGuessed++;
            guessedRight = 1;
        }
    }

    if(guessedRight)
    {
        checkWon(); 
    }
    else 
    {
        removeLife(); 
    }
  
	  if(!finish) 
    {
        guessesPush();
        alphabetIndex = 0;
        currentLetter = alphabet[0];
    }
}

void guessesPush()
{
    for(int i = 0; i < strlen(guesses); i++)
    {
        if(guesses[i] == ' ')
        {
            guesses[i] = currentLetter;
            break;
        }
    }
}

void removeLife()
{
    lives--;
    if(lives == 0)
    {
        strcpy(displayWord,wordToGuess);
        currentLetter = '*';
      	flagPerdiste = 1;
        finish = 1;
      	flagResultado = 0;
    }
}

void checkWon()
{
    if(lettersGuessed == strlen(wordToGuess))
    {
        currentLetter = '*';
        finish = 1;
      	flagResultado = 0;
        flagPerdiste = 0;
    }
}

void initGuesses()
{
    for(int i = 0; i < strlen(wordToGuess);i++)
    {
        guesses[i] = ' ';
    }
}

void borrarError()
{
  for(int i = 0 ; i < strlen(auxError); i++)
  {
    lcd.setCursor(i,1);
    lcd.print(' ');
  }
}

int leerBoton(){
  int valorA0 = analogRead(A0);

  if(valorA0>502 && valorA0<522)
    return SUBIR_LETRA;

  if(valorA0>672 && valorA0<692)
    return PROBAR_LETRA;

  if(valorA0>757 && valorA0<777)
    return BAJAR_LETRA;

  return NO_BOTON;
}

void showLives(int lives)
{
  lcd.setCursor(10,0);
  lcd.print("LP:");
  switch(lives)
  {
    case 3:
    lcd.setCursor(13,0);
    lcd.print("*");
    lcd.setCursor(14,0);
    lcd.print("*");
    lcd.setCursor(15,0);
    lcd.print("*");
    break;
    case 2:
    lcd.setCursor(13,0);
    lcd.print("*");
    lcd.setCursor(14,0);
    lcd.print("*");
    lcd.setCursor(15,0);
    lcd.print(" ");
    break;
    case 1:
    lcd.setCursor(13,0);
    lcd.print("*");
    lcd.setCursor(14,0);
    lcd.print(" ");
    lcd.setCursor(15,0);
    lcd.print(" ");
    break;
    case 0:
    lcd.setCursor(13,0);
    lcd.print(" ");
    lcd.setCursor(14,0);
    lcd.print(" ");
    lcd.setCursor(15,0);
    lcd.print(" ");
    break;
  }
}
