using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AntennVerificator
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread animatorThread;

        private static double interval;

        public static bool isWork = false;

        public static void Start()
        {
            isWork = true;
            interval = 14;

            animatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            animatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            while (isWork)
            {
                AnimationList.RemoveAll(a => a.Status == Animation.AnimationStatus.Completed);

                Parallel.For(0, Count(), index =>
                {
                    AnimationList[index].UpdateFrame();
                });

                Thread.Sleep((int)interval);
            }
        }

        public static void Request(Animation anim, bool replaceIfExists = true)
        {
            anim.Status = Animation.AnimationStatus.Requested;

            Animation dupAnim = GetDuplicate(anim);

            if (dupAnim != null)
            {
                if (replaceIfExists)
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                else
                    return;
            }

            AnimationList.Add(anim);
        }

        private static Animation GetDuplicate (Animation anim)
        {
            return AnimationList.Find(a => a.ID == anim.ID);
        }
    }
}
