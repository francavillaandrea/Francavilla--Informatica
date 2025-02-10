import pygame
import random

# Initialize Pygame
pygame.init()

# Set up game screen
screen_width = 640
screen_height = 480
screen = pygame.display.set_mode((screen_width, screen_height))
pygame.display.set_caption("Pac-Man")

# Set up game clock
clock = pygame.time.Clock()

# Load images
pacman_image = pygame.image.load('pacman.png')
ghost_image = pygame.image.load('ghost.png')
pellet_image = pygame.image.load('pellet.png')
power_pellet_image = pygame.image.load('power_pellet.png')
wall_image = pygame.image.load('wall.png')

# Set up game variables
pacman_x = 32
pacman_y = 32
pacman_direction = 'right'
ghosts = []
ghosts.append({'x': 288, 'y': 224, 'direction': 'up'})
ghosts.append({'x': 320, 'y': 224, 'direction': 'up'})
ghosts.append({'x': 352, 'y': 224, 'direction': 'up'})
ghosts.append({'x': 320, 'y': 192, 'direction': 'up'})
pellets = []
power_pellets = []
walls = []
level = 1
score = 0

#
