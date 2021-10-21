#include <assert.h>
#include "Joueur.h"

Joueur::Joueur( bool white )
{
    m_white = white;
    int p   = 0;
    int y   = ( white ? 1 : 8 );
    for ( int x = 1; x <= 8; x++ )
    {
        m_pieces[p].init( x, y, white );
        p++;
    }
    y = ( white ? 2 : 7 );
    for ( int x = 1; x <= 8; x++ )
        m_pieces[p++].init( x, y, white );
    assert( p == 16 );
}

bool
Joueur::isWhite()
{
    return m_white;
}

void
Joueur::affiche()
{
    for ( int i = 0; i < 16; i++ )
        m_pieces[i].affiche();
}