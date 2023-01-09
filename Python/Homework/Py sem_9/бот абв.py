# Урок 9. Возможна ли жизнь без PIP?
# 1) Напишите Бота, удаляющего из текста все слова, содержащие "абв". (Ввод от пользователя)

from telegram import Bot
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters, ConversationHandler
from random import randint as rd


bot = Bot(token="5877452533:AAEogg4E_d6AplIEYtvfew_gmH1rmYlarEs")
updater = Updater(token="5877452533:AAEogg4E_d6AplIEYtvfew_gmH1rmYlarEs")
dispatcher = updater.dispatcher

def start(update, context):
    context.bot.send_message(update.effective_chat.id,"Здравствуйте!\nВведите текст")

txt = input("Введите текст через пробел:\n")
print(f"Исходный текст: {txt}")
find_txt = "абв"
lst = [i for i in txt.split() if find_txt not in i]
print(f'Результат: {" ".join(lst)}')

def cancel(update, context):
    context.bot.send_message(update.effective_chat.id,"Прощай")

start_handler = CommandHandler('start', start)
bet_handler = MessageHandler(Filters.text, bet)

dispatcher.add_handler(start_handler)
dispatcher.add_handler(bet_handler)

updater.start_polling()
updater.idle()