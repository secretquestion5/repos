using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Npgsql;
using System.Data;
using System.Data.Entity;


namespace SimpleBase
{
    class ItemsBase
    {
        private readonly string connectionString = "Host=localhost;Database=kurs;Username=postgres;Password=pa77w0rd";

        public NpgsqlDataReader Get()
        {
            var connection = new NpgsqlConnection(connectionString);
            var command = new NpgsqlCommand("select * from base", connection);
            connection.Open();
            return command.ExecuteReader();
        }

        public void Add (Items item)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var command = new NpgsqlCommand($"insert into base(variant, surname, cable, closure, converter, transiver, opticalamplifier, mux, switch, transponder, price) values({item.Variant},'{item.Surname}','{item.Cable}', '{item.Closure}', '{item.Converter}', '{item.Transiver}','{item.OpticalAmplifier}','{item.MUX}', '{item.Switch}', '{item.Transponder}', '{item.Price}')", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Remove(int index)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var command = new NpgsqlCommand($"delete from base where id = {index}", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Edit(int index, Items item)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                var command = new NpgsqlCommand($"update base set variant = {item.Variant}, surname='{item.Surname}', cable = '{item.Cable}', closure = '{item.Closure}', converter = '{item.Converter}', transiver = '{item.Transiver}', opticalamplifier = '{item.OpticalAmplifier}', mux = '{item.MUX}', switch = '{item.Switch}', transponder = '{item.Transponder}', price = '{item.Price}' where id = {index}", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
