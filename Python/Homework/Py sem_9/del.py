from telegram import Bot
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters, ConversationHandler
from random import randint as rd

bot = Bot(token="5877452533:AAEogg4E_d6AplIEYtvfew_gmH1rmYlarEs")
updater = Updater(token="5877452533:AAEogg4E_d6AplIEYtvfew_gmH1rmYlarEs")
dispatcher = updater.dispatcher

def start(update, context):
     context.bot.send_message(update.effective_chat.id, 'Привет!\n\nЯ умею удалять из твоих сообщений слова, в которых есть сочетание "абв"')
     context.bot.send_message(update.effective_chat.id, 'Напиши мне любое сообщение, и я верну его обратно без слов с "абв"')
     

def del_abv(update, context):
    text = update.message.text.split()
    list1 = []
    for i in text:
        if "абв" in i:
            list1.append(i)
    context.bot.send_message(update.effective_chat.id, " ".join(list1))

start_handler = CommandHandler('start', start)
message_handler = MessageHandler(Filters.text, del_abv)

dispatcher.add_handler(start_handler)
dispatcher.add_handler(message_handler)

updater.start_polling()
updater.idle()