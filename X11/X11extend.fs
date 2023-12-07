\ *********************************************************************
\ Extensions for X11 vocabulary
\    Filename:      X11extend.fs
\    Date:          04 dec 2023
\    Updated:       07 dec 2023
\    File Version:  1.0
\    MCU:           ---
\    Forth:         eForth Linux
\    Copyright:     Marc PETREMANN
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ source pour toutes les fonctions
\   https://tronche.com/gui/x/xlib/appendix/a.html#PolyLine


x11 definitions
z" XCloseDisplay"   1 xlib XCloseDisplay ( display -- a )
z" XFlush"          1 xlib XFlush ( display -- a )
z" XSync"           2 xlib XSync ( display discard -- a )
z" XDrawPoint"      5 xlib (XDrawPoint ( display win gc x y )
z" XDrawLine"       7 xlib XDrawLine ( display win gc x y dx dy )
z" XDrawRectangle"  7 xlib XDrawRectangle ( display win gc 120 150 50 60 )




forth definitions








\ XDrawArc(display, d, gc, x, y, width, height, angle1, angle2)
\ z" XDrawArc" 1 xlib XDrawArc ( a -- a )

\ XDrawLine(display, d, gc, x1, y1, x2, y2)


\ XDrawRectangle(display, d, gc, x, y, width, height)


\ XDrawRectangles(display, d, gc, rectangles, nrectangles)



