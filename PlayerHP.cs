using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//lager en namespace dette gjør at jeg kan få tak i dette scripte fra andre filler
namespace PlayerHealth
{
    public class PlayerHP : MonoBehaviour
    {
        //variabel
        public int HP = 30;
        public SpriteRenderer m_SpriteRenderer;
        public Color m_NewColor;

        //globalt tilgjengelig klasse som finnes i scenen, men bare én gang. jeg bruker instance på samme måte som jeg bruker getcomponent fra playermovement
        public static PlayerHP Instance;
        private void OnEnable()
        {
            if (Instance == null)
                Instance = this;
            else Destroy(gameObject);
        }


        //det som tar dmg av med å sier at det skal til funksjonenn som gjør at jeg bytter farge
        public void TakeDamage (int damage)
        {
            HP -= damage;
            if (HP <= 0)
            {
                Die();
            } else {
                UpdateColor();
            }
        }


        //det som gir meg liv og funksjonenn som gjør at jeg bytter farge
        public void GiveHealth(int GiveHPToPlayer)
        {
            HP += GiveHPToPlayer;
            if (HP >= 30){
                HP = 30;
            }
            UpdateColor();
        }


        //disse 2 funskjonenenene render frager på min player å bytter farge till det jeg har satt den
        private void HealthStage(int StageHP, Color stageColor)
        {
            if (HP == StageHP)
            {
                m_NewColor = stageColor;
                m_SpriteRenderer.color = m_NewColor;
            }
        }


        public void UpdateColor ()
        {
            HealthStage(30, new Color(0,255,0));
            HealthStage(20, new Color(249,255,0));
            HealthStage(10, new Color(255,0,0));
        }


        //når den er 0 blir player gameogjecte ødlagt
        void Die ()
        {
            Destroy(gameObject);
        }
    }

}
