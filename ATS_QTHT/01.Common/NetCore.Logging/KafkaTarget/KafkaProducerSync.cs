using System;
using Confluent.Kafka;
using NetCore.Logging.KafkaTarget;

namespace SNetCore.Logging.KafkaTarget
{
    public class KafkaProducerSync : KafkaProducerAbstract
    {
        public KafkaProducerSync(string brokers, string lingerMs) : base(brokers, lingerMs)
        {
        }

        public override void Produce(ref string topic, ref byte[] data)
        {
            Producer.Produce(topic, new Message<string, byte[]>
            {
                Key = Guid.NewGuid().ToString(),
                Value = data
            });
        }
    }
}