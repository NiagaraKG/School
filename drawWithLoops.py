# Import a library of functions called 'pygame'
import pygame

# Initialize the game engine
pygame.init()

# Define some colors
black    = (   0,   0,   0)
white    = ( 255, 255, 255)
green    = (   0, 255,   0)
red      = ( 255,   0,   0)
blue     = ( 0,   0,   255)

# Set the width and height of the screen [width,height]
size=[700,500]
pi = 3.141592

screen=pygame.display.set_mode(size)

pygame.display.set_caption('Hello World!')

#Loop until the user clicks the close button.
done=False

# Used to manage how fast the screen updates
clock=pygame.time.Clock()

while done==False: # main game loop
    # ALL EVENT PROCESSING SHOULD GO BELOW THIS COMMENT
    for event in pygame.event.get(): # User did something
        if event.type == pygame.QUIT: # If user clicked close
            done=True # Flag that we are done so we exit this loop
    # ALL EVENT PROCESSING SHOULD GO ABOVE THIS COMMENT

    # ALL GAME LOGIC SHOULD GO BELOW THIS COMMENT

    # ALL GAME LOGIC SHOULD GO ABOVE THIS COMMENT

    # First, clear the screen to white. Don't put other drawing commands
    # above this, or they will be erased with this command.
    screen.fill(white)

    # Draw on the screen a green line from (0,0) to (100,100) 
    # that is 5 pixels wide.
    pygame.draw.line(screen,green,[0,0],[100,100],5)
    # Draw on the screen several green lines from (0,10) to (100,110) 
    # 5 pixels wide using a for loop
    for y_offset in range(0,100,10):
        pygame.draw.line(screen,red,[0,10+y_offset],[100,110+y_offset],5)
    # Draw a rectangle
    pygame.draw.rect(screen,black,[20,20,250,100],2)
    # Draw an ellipse, using a rectangle as the outside boundaries
    pygame.draw.ellipse(screen,green,[20,20,250,100])
    # Draw an arc as part of an ellipse. Use radians to determine what
    # angle to draw.
    pygame.draw.arc(screen,red,[100,100,250,200],  pi/2,     pi, 2)
    pygame.draw.arc(screen,black,[100,100,250,200],     0,   pi/2, 2)
    pygame.draw.arc(screen,green,  [100,100,250,200],3*pi/2,   2*pi, 2)
    pygame.draw.arc(screen,blue, [100,100,250,200],    pi, 3*pi/2, 2)

    # ALL CODE TO DRAW SHOULD GO ABOVE THIS COMMENT
    
    # Go ahead and update the screen with what we've drawn.
    pygame.display.flip()
    # Limit to 30 frames per second
    clock.tick(30)

# Close the window and quit.
# If you forget this line, the program will 'hang'
# on exit if running from IDLE.
pygame.quit()
