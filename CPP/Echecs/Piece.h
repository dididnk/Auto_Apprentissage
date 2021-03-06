/**
 * Header de Piece.cxx
 *
 * @file Piece.h
 */

#if !defined Piece_h
#define Piece_h

/**
 * Declaration d'une classe modelisant une piece de jeu d'echec.
 */
class Piece
{
   private:
    int  m_x;
    int  m_y;
    bool m_white;

   public:
    ~Piece();
    Piece();
    Piece( int x, int y, bool white );
    Piece(const Piece & autre);
    Piece & operator= (const Piece & autre);
    void init( int x, int y, bool white );
    void move( int x, int y );
    int  x();
    int  y();
    bool isWhite();
    bool isBlack();
    void affiche();
};

Piece *allouerPiece(int x, int y, bool white);

#endif  // !defined Piece_h
