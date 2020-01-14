using Experimental.System.Messaging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helper
{
    public class MSMQ
    {
        private readonly string queueName;
        MessageQueue msMq = null;

        public MSMQ(string queueName)
        {
            this.queueName = queueName;
        }

        public void Send()
        {
            // check if queue exists, if not create it



            if (!MessageQueue.Exists(queueName))
            {

                msMq = MessageQueue.Create(queueName);

            }

            else
            {

                msMq = new MessageQueue(queueName);

            }




            try
            {

                // msMq.Send("Sending data to MSMQ at " + DateTime.Now.ToString());

                Message msg = new Message();



                msMq.Send(msg);

            }

            catch (MessageQueueException ee)
            {

                Console.Write(ee.ToString());

            }

            catch (Exception eee)
            {

                Console.Write(eee.ToString());

            }

            finally
            {

                msMq.Close();

            }

            Console.WriteLine("Message sent ......");



        }


        public void Recieve()
        {
            try

            {

                // msMq.Formatter = new XmlMessageFormatter(new Type[] {typeof(string)});

                msMq.Formatter = new XmlMessageFormatter(new Type[] { typeof(Message) });

                var message = (Message)msMq.Receive().Body;

                Console.WriteLine("Message: " + message);

                // Console.WriteLine(message.Body.ToString());

            }

            catch (MessageQueueException ee)

            {

                Console.Write(ee.ToString());

            }

            catch (Exception eee)

            {

                Console.Write(eee.ToString());

            }

            finally

            {

                msMq.Close();

            }

            Console.WriteLine("Message received ......");
        }
    }
}
