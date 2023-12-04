\ *********************************************************************
\ display UTF8 characters table
\    Filename:      utf8Set.fs
\    Date:          04 dec 2023
\    Updated:       04 dec 2023
\    File Version:  1.0
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


: supLatin1 ( -- )
    $a0 $ff utf8Set
  ;

: latin1extendedA ( -- )
    $100 $17f utf8Set
  ;

: latin1extendedB ( -- )
    $180 $24f utf8Set
  ;

: APIsupplement ( -- )
    $250 $2af utf8Set
  ;

: modificativesLetters ( -- )
    $2b0 $2ff utf8Set
  ;

: diacritics ( -- )
    $300 $36f utf8Set
  ;

: greekAndCopt ( -- )
    $370 $3ff utf8Set
  ;

: cyrilliq ( -- )
    $400 $4ff utf8Set
  ;



suplatin1




