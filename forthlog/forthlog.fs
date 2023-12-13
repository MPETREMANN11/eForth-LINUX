\ *********************************************************************
\ FORTHLOG - main file
\    Filename:      forthlog.fs
\    Date:          13 dec 2023
\    Updated:       13 dec 2023
\    File Version:  1.0
\    MCU:           ESP32-WROOM-32
\    Forth:         eForth all versions
\    Copyright:     Marc PETREMANN
\    Author:        Francis LEY
\    Adapt. eForth: Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ *** backup and restoration of TIB ***********************************

80 constant LG-TIB
create #SAUV-TIB  LG-TIB allot
variable #SAUV-IN
variable #S-IN
variable #RAB-BLOC

: SAUV-TIB ( -- )
    TIB @ #SAUV-TIB LG-TIB cmove
    IN    #SAUV-IN !
  ;

: REST-TIB ( -- )
    #SAUV-TIB TIB @ LG-TIB CMOVE
    #SAUV-IN @ IN !
  ;

: RAB-BLOC ( -- )
    #RAB-BLOC @ 1 = if
        TIB @ #S-IN @ +
        IN @ #S-IN @ - BLANKS
    then
  ;

\  *** managing a table of several variables **************************

\ maximum number of variables available
150 constant MAX-VAR

\ max length of variable content
20 constant LG-VAR

\ dimension of the table of 150 variables
MAX-VAR LG-VAR * constant LG-TABVAR

\ variable pointing to the current position
variable #REC-TABVAR

\ variable table
create #TABVAR LG-TABVAR allot

\ provides the address of the current extension
: REC-TABVAR ( -- addr )
    #REC-TABVAR @ LG-VAR * #TABVAR +
  ;

\ initialization of extension number on 1st extension
: DEB-TABVAR ( -- )
    0 #REC-TABVAR !
  ;

\ +1 in #TABVAR post counter
: +1-TABVAR ( -- )
    1 #REC-TABVAR +!
  ;

\ Reset the entire TABVAR table
: RAB-TABVAR ( -- )
    #TABVAR LG-TABVAR BLANKS
  ;

\ search for 1st free position in TABVAR
: LIB-TABVAR
    0 MAX-VAR @
    DO
        i #REC-TABVAR !  REC-TABVAR c@ 32 =
        if
            1+ leave
        then
    LOOP
    0= if
        ." #TABVAR full"
        quit
    then
  ;


\ *** treatment of conditions *****************************************

variable #E-COND        \ state conditions
variable #E-ACTION      \ state action
variable #NBR-PRE       \ number of predicates on stack
variable #T-COND-V      \ treatment condition verified

: SI
\     SP!
    0 #NBR-PRE !
    1 #E-COND !
    0 #E-ACTION !
    0 #T-COND-V !
    0 #RAB-BLOC ;
  ;

\ variable for debugging
variable #DEBUG

\ variable if inference is successful
variable #INFER

: ALORS
\     SP!
    0 #E-COND !
    1 #E-ACTION !
    #NBR-PRE @
    #T-COND-V @ = if
        \ display of the action taken
        #DEBUG @ 0= if
            cr ." REPONSE: "
        then
        1 #INFER !  
        1 #RAB-BLOC !
    else
        TIB @ LG-TIB BLANKS
    then
  ;












