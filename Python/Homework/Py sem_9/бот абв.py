# РЕШЕНИЯ С СЕМИНАРА
# Урок 9. Возможна ли жизнь без PIP? 
# 1) Напишите Бота, удаляющего из текста все слова, содержащие "абв". (Ввод от пользователя)

from telegram import Bot
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters, ConversationHandler
from random import randint as rd

bot = Bot(token="5877452533:AAEogg4E_d6AplIEYtvfew_gmH1rmYlarEs")
updater = Updater(token="5877452533:AAEogg4E_d6AplIEYtvfew_gmH1rmYlarEs")
dispatcher = updater.dispatcher


# def del_abv(update, context):
#     text = update.message.text.split()
#     list1 = []
#     for i in text:
#         if "абв" in i:
#             list1.append(i)
#     context.bot.send_message(update.effective_chat.id, " ".join(list1))


def del_abvV2(update, context):
    text = update.message.text.split()
    list1 = []
    for i in text:
        if "абв" in i:
            list1.append(i)
    context.bot.send_message(update.effective_chat.id, " ".join(list1[1:]))


hand_com = CommandHandler("filter", del_abvV2) # тут будет через команду /filter и вводимый текст
# del_handler = MessageHandler(Filters.text, del_abv)
# dispatcher.add_handler(del_handler)
dispatcher.add_handler(hand_com)

updater.start_polling()
updater.idle()