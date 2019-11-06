import os

board_input, player1, player2, last, gametype, wincount_player1, wincount_player2 = ['©Arthurdw', ' ', ' ', ' ', ' ',
                                                                                     ' ', ' ', ' ', ' ',
                                                                                     ' '], '', '', 'O', '', 0, 0


def setup():
    global gametype, player1, player2
    while gametype == '':
        os.system("cls")
        game = input('Welcome to the Tic-Tac-Toe/OXO.\nPlease select the game you want to play! (Tic/OXO)\n')
        if game.lower() == 'tic':
            gametype = 'Tic-Tac-Toe'
        elif game.lower() == 't':
            gametype = 'Tic-Tac-Toe'
        elif game.lower() == 'oxo':
            gametype = 'OXO'
        elif game.lower() == 'o':
            gametype = 'OXO'
    player1, player2 = player_input()
    start(board_input)


def reset():
    global board_input
    board_input = ['©Arthurdw', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ']
    start(board_input)


def display(board):
    os.system("cls")
    sp, tr = ' ', ' ' * 3
    pr = f'{tr}|{tr}|{tr}'
    print(
        f'{pr}\n{sp}{board[7]}{sp}|{sp}{board[8]}{sp}|{sp}{board[9]}\n{pr}\n-----------\n{pr}\n{sp}{board[4]}{sp}|{sp}'
        f'{board[5]}{sp}|{sp}{board[6]}\n{pr}\n-----------\n{pr}\n{sp}{board[1]}{sp}|{sp}{board[2]}{sp}|{sp}'
        f'{board[3]}\n{pr}\n')


def player_input():
    global player1, player2, last
    required = ['X', 'O']
    while player1 not in required:
        os.system("cls")
        player1 = input('Player 1, choose X or O: ').upper()
        if player1 == 'X':
            player2 = 'O'
            last = 'X'
        elif player1 == 'O':
            player2 = 'X'
    return (player1, player2)


def end(player):
    global wincount_player1, wincount_player2
    choice = ''
    required = ['y', 'yes', 'n', 'no']
    if player == 'Player 1': wincount_player1 += 1
    if player == 'Player 2': wincount_player2 += 1
    while choice not in required:
        os.system("cls")
        display(board_input)
        print(f'{player} won the game!\n\nPlayer 1: {wincount_player1} win(s).\nPlayer 2: {wincount_player2} win(s).\n')
        choice = str(input('Would you like to play again? (Yes/No)\n')).lower()
        if 'y' == choice.lower():
            reset()
        elif 'yes' == choice.lower():
            reset()
        if 'n' == choice.lower():
            print('Thanks for playing!')
            return True
        elif 'n' == choice.lower():
            print('Thanks for playing!')
            return True


def insert():
    global last, board_input
    location = ''
    while location == '':
        try:
            location = input(f'Please insert the location (1-9)[{last}]: ')
            if location.lower() == 'r':
                choice = input('Would you like to reset the board? This action is irreversible! (Yes/No)\n').lower()
                if 'y' == choice.lower():
                    reset()
                elif 'yes' == choice.lower():
                    reset()
                else:
                    print(f'Canceled board reset.')
            elif int(location) not in range(1, 10):
                return
            elif board_input[int(location)] == ' ':
                board_input[int(location)] = last
                break
            else:
                print(
                    f'The \'{location}\' place is already taken. :0\nTry again! ;)\nIf you would like to reset the board type \'R\'!')
        except ValueError:
            os.system("cls")
            display(board_input)
            print('Couldn\'t recognize that character!')
    if last == 'X':
        last = 'O'
    elif last == 'O':
        last = 'X'


def start(board):
    while True:
        global gametype
        display(board_input)
        insert()

        def check(items):
            patterns = [(1, 4, 7), (1, 2, 3), (1, 5, 9), (4, 5, 6), (7, 8, 9), (7, 5, 3), (2, 5, 8), (3, 6, 9)]
            for item in patterns:
                if board[item[0]] + board[item[1]] + board[item[2]] == items: return True

        won = False
        if gametype == 'Tic-Tac-Toe':
            if check('XXX'):
                won = True
            elif check('OOO'):
                won = True
        elif gametype == 'OXO':
            if check('OXO'):
                won = True
            elif check('XOX'):
                won = True
        if won:
            global player1, player2, last
            end_game = False
            if player1 != last:
                end_game = end('Player 1')
            elif player2 != last:
                end_game = end('Player 2')
            if end_game: break


setup()
